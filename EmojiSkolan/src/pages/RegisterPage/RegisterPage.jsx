import './RegisterPage.css';
import { useState, useEffect, useRef } from 'react';
import { useNavigate } from 'react-router-dom';
import { validateInputs } from '../../utils/validateInputs';
import { useAuth } from '../../context/AuthContext';
import { useMultiForm } from '../../context/MultiFormContext';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';
import bcrypt from 'bcryptjs';

// Avatar options (index matches avatar in db.json)
const avatars = [
  { id: 0, emoji: '😊', label: 'Glad' },
  { id: 1, emoji: '🤓', label: 'Glasögon' },
  { id: 2, emoji: '👽', label: 'Alien' },
];

const RegisterPage = () => {
  const formRef = useRef();
  const navigate = useNavigate();
  const { setFormRef } = useMultiForm();
  // State for user input values
  const [formData, setFormData] = useState({
    username: '',
    email: '',
    password: '',
    confirmPassword: '',
    avatar: 0,
  });

  // State for checkbox: accept terms
  const [acceptTerms, setAcceptTerms] = useState(false);

  // State for validation errors and valid flags
  const [errors, setErrors] = useState({});
  const [valid, setValid] = useState({});

  // State for server-side error messages
  const [serverError, setServerError] = useState('');

  // State to track password visibility
  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);

  // State to track which input is currently hovered
  const [hoveredField, setHoveredField] = useState(null);

  useEffect(() => {
    setFormRef('register', formRef);
  }, [setFormRef]);

  // Validate inputs every time formData changes
  useEffect(() => {
    const { errors, valid } = validateInputs(formData);
    setErrors(errors);
    setValid(valid);
    setServerError(''); // Clear server error when user changes input
  }, [formData]);

  // Check if all fields are valid AND terms are accepted
  const isFormValid = Object.values(valid).every(Boolean) && acceptTerms;

  // Updates formData when user types in any input field
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: name === 'avatar' ? Number(value) : value,
    }));
  };

  // Clears the value of a specific input field
  const handleClear = (field) => {
    setFormData((prev) => ({ ...prev, [field]: '' }));
  };

  // Handles form submission
  const handleSubmit = async (e) => {
    e.preventDefault();
    setServerError(''); // reset server error on each submit

    // Validate again on submit
    const { errors: newErrors, valid: newValid } = validateInputs(formData);
    setErrors(newErrors);
    setValid(newValid);

    if (!Object.values(newValid).every(Boolean)) return;

    try {
      // Check if username or email already exists
      const res = await fetch('http://localhost:5132/api/users');
      const users = await res.json();

      const exists = users.find(
        (user) => user.username === formData.username || user.email === formData.email
      );

      if (exists) {
        setServerError('Användarnamn eller e-post är redan registrerat.');
        return; // stop registration
      }

      // Hash the password before sending to server
      const hashedPassword = await bcrypt.hash(formData.password, 10);

      // Create user object with hashed password
      const newUser = {
        username: formData.username,
        email: formData.email,
        passwordHash: hashedPassword, // matchar backend
        avatarId: formData.avatar, // matchar backend
        // level: 1,
      };

      console.log('New user object:', newUser);

      // Send user data to json-server
      const postRes = await fetch('http://localhost:5132/api/users', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(newUser),
      });

      if (!postRes.ok) {
        throw new Error('Failed to save user');
      }
      console.log('User registration response status:', postRes.status); // Debug log
      // ...efter postRes...
      if (postRes.ok) {
        const createdUser = await postRes.json();
        console.log('Created user response:', createdUser); // Debug log
        const newUserId = createdUser.id; // Använd camelCase som backend returnerar
        console.log('New user ID:', newUserId); // Debug log
        console.log('localStorage lastResult:', localStorage.getItem('lastResult')); // Debug log
        // Spara gästresultat om det finns
        const lastResult = localStorage.getItem('lastResult');
        console.log('Last result from localStorage:', lastResult); // Debug log
        if (lastResult) {
          const { rounds, time, level } = JSON.parse(lastResult);
          console.log('Saving guest result:', rounds, time, level);

          try {
            const recordResponse = await fetch(
              `http://localhost:5132/api/users/${newUserId}/records`,
              {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                  LevelId: level, // PascalCase för backend
                  Rounds: rounds, // PascalCase för backend
                  Time: time, // PascalCase för backend
                }),
              }
            );

            if (recordResponse.ok) {
              console.log('Guest result saved successfully');
              localStorage.removeItem('lastResult');
            } else {
              console.error('Failed to save guest result:', recordResponse.status);
            }
          } catch (recordError) {
            console.error('Error saving guest result:', recordError);
          }
        }

        alert('Registrering lyckades!');
        navigate('/login'); // Byter till useNavigate istället för window.location
      }
    } catch (err) {
      console.error('Registration failed:', err);
      alert('Registrering misslyckades!');
    }
  };

  return (
    <div style={{ maxWidth: '400px', margin: 'auto', padding: '1rem' }}>
      <h2>Registrera här</h2>

      {/* Show server-side error if exists */}
      {serverError && <p style={{ color: 'red', fontWeight: 'bold' }}>{serverError}</p>}

      <form ref={formRef} onSubmit={handleSubmit}>
        {/* Username input */}
        <Input
          className="input-field"
          label="Användarnamn"
          type="text"
          name="username"
          value={formData.username}
          onChange={handleChange}
          onClear={() => handleClear('username')}
          error={errors.username}
          valid={valid.username}
          hovered={hoveredField === 'username'}
          setHovered={(val) => setHoveredField(val ? 'username' : null)}
          autoFocus
        />

        {/* Email input */}
        <Input
          label="E-post"
          type="email"
          name="email"
          value={formData.email}
          onChange={handleChange}
          onClear={() => handleClear('email')}
          error={errors.email}
          valid={valid.email}
          hovered={hoveredField === 'email'}
          setHovered={(val) => setHoveredField(val ? 'email' : null)}
        />

        {/* Password input */}
        <div style={{ display: 'flex', alignItems: 'center' }}>
          <Input
            label="Lösenord"
            type={showPassword ? 'text' : 'password'}
            name="password"
            value={formData.password}
            onChange={handleChange}
            onClear={() => handleClear('password')}
            error={errors.password}
            valid={valid.password}
            hovered={hoveredField === 'password'}
            setHovered={(val) => setHoveredField(val ? 'password' : null)}
          />
          <button
            type="button"
            onClick={() => setShowPassword((prev) => !prev)}
            style={{ marginLeft: '0.5rem', height: '2.5rem' }}
            tabIndex={-1}
          >
            {showPassword ? 'Dölj' : 'Visa'}
          </button>
        </div>

        {/* Confirm password input */}
        <div style={{ display: 'flex', alignItems: 'center' }}>
          <Input
            label="Bekräfta lösenord"
            type={showConfirmPassword ? 'text' : 'password'}
            name="confirmPassword"
            value={formData.confirmPassword}
            onChange={handleChange}
            onClear={() => handleClear('confirmPassword')}
            error={errors.confirmPassword}
            valid={valid.confirmPassword}
            hovered={hoveredField === 'confirmPassword'}
            setHovered={(val) => setHoveredField(val ? 'confirmPassword' : null)}
          />
          <button
            type="button"
            onClick={() => setShowConfirmPassword((prev) => !prev)}
            style={{ marginLeft: '0.5rem', height: '2.5rem' }}
            tabIndex={-1}
          >
            {showConfirmPassword ? 'Dölj' : 'Visa'}
          </button>
        </div>

        {/* Avatar selection */}
        <div style={{ margin: '1rem 0' }}>
          <label className="label-title" htmlFor="avatar">
            Välj en avatar:
          </label>
          <div style={{ display: 'flex', gap: '1rem', marginTop: '0.5rem' }}>
            {avatars.map((a) => (
              <label key={a.id} style={{ cursor: 'pointer', fontSize: '2rem' }}>
                <input
                  type="radio"
                  name="avatar"
                  value={a.id}
                  checked={formData.avatar === a.id}
                  onChange={handleChange}
                  style={{ marginRight: '0.5rem' }}
                />
                {a.emoji}
              </label>
            ))}
          </div>
        </div>

        {/* Text above the terms checkbox */}
        <div style={{ marginTop: '1rem', marginBottom: '0.5rem' }}>
          <span>Villkor för att bli bäst och äga detta spelet!</span>
        </div>

        {/* Checkbox for accepting terms */}
        <div>
          <label>
            <input
              type="checkbox"
              checked={acceptTerms}
              onChange={(e) => setAcceptTerms(e.target.checked)}
            />
            Jag godkänner villkoren
          </label>
        </div>

        {/* Submit button and terms accepted */}
        <button
          type="submit"
          disabled={!isFormValid}
          className="invisible-btn"
          style={{ marginTop: '1rem' }}
        >
          Registrera användare
        </button>
      </form>
    </div>
  );
};

export default RegisterPage;
