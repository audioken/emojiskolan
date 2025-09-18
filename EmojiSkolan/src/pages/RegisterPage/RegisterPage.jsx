import './RegisterPage.css';
import { useState, useEffect, useRef, use } from 'react';
import { useNavigate } from 'react-router-dom';
import { useMultiForm } from '../../context/MultiFormContext';
import { useInstruction } from '../../context/InstructionContext';
import { validateInputs } from '../../utils/validateInputs';
import instructionMessages from '../../utils/instructionMessages';
import Input from '../../components/UI/Input/Input';
import bcrypt from 'bcryptjs';

const avatars = [
  { id: 0, emoji: '😊', label: 'Glad' },
  { id: 1, emoji: '🤓', label: 'Glasögon' },
  { id: 2, emoji: '👽', label: 'Alien' },
];

const RegisterPage = () => {
  const formRef = useRef();
  const navigate = useNavigate();
  const { showMessage } = useInstruction();
  const { setFormRef } = useMultiForm();

  const [formData, setFormData] = useState({
    username: '',
    email: '',
    password: '',
    confirmPassword: '',
    avatar: 0,
  });

  const [acceptTerms, setAcceptTerms] = useState(false);

  const [errors, setErrors] = useState({});
  const [valid, setValid] = useState({});

  const [serverError, setServerError] = useState('');

  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);

  const [hoveredField, setHoveredField] = useState(null);

  useEffect(() => {
    showMessage(instructionMessages.get('register'));
  }, []);

  useEffect(() => {
    setFormRef('register', formRef);
  }, [setFormRef]);

  useEffect(() => {
    const { errors, valid } = validateInputs(formData);
    setErrors(errors);
    setValid(valid);
    setServerError('');
  }, [formData]);

  const isFormValid = Object.values(valid).every(Boolean) && acceptTerms;

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: name === 'avatar' ? Number(value) : value,
    }));
  };

  const handleClear = (field) => {
    setFormData((prev) => ({ ...prev, [field]: '' }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setServerError('');

    const { errors: newErrors, valid: newValid } = validateInputs(formData);
    setErrors(newErrors);
    setValid(newValid);

    if (!Object.values(newValid).every(Boolean)) return;

    try {
      const res = await fetch('http://localhost:5132/api/users');
      const users = await res.json();

      const exists = users.find(
        (user) => user.username === formData.username || user.email === formData.email
      );

      if (exists) {
        setServerError('Användarnamn eller e-post är redan registrerat.');
        return;
      }

      const hashedPassword = await bcrypt.hash(formData.password, 10);

      const newUser = {
        username: formData.username,
        email: formData.email,
        passwordHash: hashedPassword,
        avatarId: formData.avatar,
      };

      const postRes = await fetch('http://localhost:5132/api/users', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(newUser),
      });

      if (!postRes.ok) {
        throw new Error('Failed to save user');
      }

      if (postRes.ok) {
        const createdUser = await postRes.json();

        const newUserId = createdUser.id;

        const lastResult = localStorage.getItem('lastResult');

        if (lastResult) {
          const { rounds, time, level } = JSON.parse(lastResult);

          try {
            const recordResponse = await fetch(
              `http://localhost:5132/api/users/${newUserId}/records`,
              {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                  LevelId: level,
                  Rounds: rounds,
                  Time: time,
                }),
              }
            );

            if (recordResponse.ok) {
              localStorage.removeItem('lastResult');
            } else {
              console.error('Failed to save guest result:', recordResponse.status);
            }
          } catch (recordError) {
            console.error('Error saving guest result:', recordError);
          }
        }

        alert('Registrering lyckades!');
        navigate('/login');
      }
    } catch (err) {
      console.error('Registration failed:', err);
      alert('Registrering misslyckades!');
    }
  };

  return (
    <main className="register-container">
      <h2>Registrera här</h2>

      {serverError && <div className="error-message">{serverError}</div>}

      <form ref={formRef} onSubmit={handleSubmit} className="register-form">
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

        <div className="password-input-group">
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
            className="password-toggle-btn"
            tabIndex={-1}
          >
            {showPassword ? 'Dölj' : 'Visa'}
          </button>
        </div>

        <div className="password-input-group">
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
            className="password-toggle-btn"
            tabIndex={-1}
          >
            {showConfirmPassword ? 'Dölj' : 'Visa'}
          </button>
        </div>

        <div className="avatar-selection">
          <label className="label-title" htmlFor="avatar">
            Välj en avatar:
          </label>
          <div className="avatar-options">
            {avatars.map((a) => (
              <label key={a.id} className="avatar-option">
                <input
                  type="radio"
                  name="avatar"
                  value={a.id}
                  checked={formData.avatar === a.id}
                  onChange={handleChange}
                />
                {a.emoji}
              </label>
            ))}
          </div>
        </div>

        <div className="terms-section">
          <div className="terms-text">Villkor för att bli bäst och äga detta spelet!</div>
          <label className="terms-checkbox">
            <input
              type="checkbox"
              checked={acceptTerms}
              onChange={(e) => setAcceptTerms(e.target.checked)}
            />
            Jag godkänner villkoren
          </label>
        </div>

        {/* Invisible submit button to allow form submission via MultiFormContext */}
        <button type="submit" className="invisible-btn"></button>
      </form>
    </main>
  );
};

export default RegisterPage;
