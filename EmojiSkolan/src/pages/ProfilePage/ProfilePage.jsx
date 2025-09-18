import './ProfilePage.css';
import { useEffect, useState, useRef } from 'react';
import { useAuth } from '../../context/AuthContext';
import { useMultiForm } from '../../context/MultiFormContext';
import { useInstruction } from '../../context/InstructionContext';
import { validateInputs } from '../../utils/validateInputs';
import { avatars } from '../../utils/avatars';
import instructionMessages from '../../utils/instructionMessages';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';
import bcrypt from 'bcryptjs';

// ProfilePage component allows user to view and update their profile
const ProfilePage = () => {
  // Get current user and updateUser function from auth context
  const { user, updateUser } = useAuth();
  const { showMessage } = useInstruction();
  // Ref and context for multi-form handling
  const formRef = useRef();
  const { setFormRef, setFormValidStatus } = useMultiForm();

  // State for user's profile fields
  const [profile, setProfile] = useState({
    username: user?.username || '',
    email: user?.email || '',
    password: '',
    confirmPassword: '',
    avatar: user?.avatar ?? 0,
  });

  useEffect(() => {
    showMessage(instructionMessages.get('profile'));
  }, []);

  // Update profile state when user changes (e.g. after reload)
  useEffect(() => {
    if (user) {
      setProfile({
        username: user.username || '',
        email: user.email || '',
        password: '',
        confirmPassword: '',
        avatar: user.avatar ?? 0,
      });
    }
  }, [user]);

  // State for validation errors and valid flags
  const [errors, setErrors] = useState({});
  const [valid, setValid] = useState({});
  const [hoveredField, setHoveredField] = useState(null);
  const [serverError, setServerError] = useState('');

  // Only enable save button if all fields are valid
  const isFormValid = Object.values(valid).every(Boolean);

  useEffect(() => {
    setFormRef('profile', formRef);
  }, [setFormRef]);

  useEffect(() => {
    setFormValidStatus('profile', isFormValid);
  }, [isFormValid, setFormValidStatus]);

  // Validate inputs whenever profile changes
  useEffect(() => {
    const { errors, valid } = validateInputs(profile, 'profile');
    setErrors(errors);
    setValid(valid);
    setServerError('');
  }, [profile]);

  // Update profile state when input changes
  function handleChange(e) {
    const { name, value } = e.target;
    setProfile((prev) => ({
      ...prev,
      [name]: value,
    }));
  }

  // Handle form submission to update user profile
  const handleSubmit = async (e) => {
    e.preventDefault();

    // Build updated user object
    const updatedUser = {
      id: user.id,
      username: profile.username,
      email: profile.email,
      avatarId: profile.avatar,
    };
    console.log(updatedUser);
    // Only send password if changed
    if (profile.password) {
      // Hash the password before sending to server
      const hashedPassword = await bcrypt.hash(profile.password, 10);
      updatedUser.passwordHash = hashedPassword;
    }

    try {
      const response = await fetch(`http://localhost:5132/api/users/${user.id}`, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(updatedUser),
      });

      if (response.ok) {
        alert('Profilen är uppdaterad!');
        // Clear password fields after successful update
        setProfile((prev) => ({
          ...prev,
          password: '',
          confirmPassword: '',
        }));
        if (typeof updateUser === 'function') {
          const updatedUserFromServer = await response.json();
          updateUser({
            ...updatedUserFromServer,
            avatar: updatedUserFromServer.avatarId, // mappa avatarId till avatar
          });
        }
      } else {
        setServerError('Misslyckades med att uppdatera profilen. Försök igen.');
      }
    } catch (err) {
      setServerError('Serverfel. Försök igen senare.');
    }
  };

  return (
    <div className="profile-container">
      <h2>Profil</h2>
      
      {/* Show server error if any */}
      {serverError && <div className="error-message">{serverError}</div>}
      
      {/* Profile form */}
      <form ref={formRef} onSubmit={handleSubmit} className="profile-form">
        {/* Username input */}
        <Input
          className="input-field"
          label="Användarnamn"
          type="text"
          name="username"
          value={profile.username}
          onChange={handleChange}
          onClear={() => setProfile((prev) => ({ ...prev, username: '' }))}
          error={errors.username}
          valid={valid.username}
          hovered={hoveredField === 'username'}
          setHovered={(val) => setHoveredField(val ? 'username' : null)}
          autoFocus
        />

        {/* Email input */}
        <Input
          className="input-field"
          label="E-post"
          type="email"
          name="email"
          value={profile.email}
          onChange={handleChange}
          onClear={() => setProfile((prev) => ({ ...prev, email: '' }))}
          error={errors.email}
          valid={valid.email}
          hovered={hoveredField === 'email'}
          setHovered={(val) => setHoveredField(val ? 'email' : null)}
        />

        {/* Password input */}
        <Input
          className="input-field"
          label="Lösenord"
          type="password"
          name="password"
          value={profile.password}
          onChange={handleChange}
          onClear={() => setProfile((prev) => ({ ...prev, password: '' }))}
          error={errors.password}
          valid={valid.password}
          hovered={hoveredField === 'password'}
          setHovered={(val) => setHoveredField(val ? 'password' : null)}
        />

        {/* Confirm Password input */}
        <Input
          className="input-field"
          label="Bekräfta lösenord"
          type="password"
          name="confirmPassword"
          value={profile.confirmPassword}
          onChange={handleChange}
          onClear={() => setProfile((prev) => ({ ...prev, confirmPassword: '' }))}
          error={errors.confirmPassword}
          valid={valid.confirmPassword}
          hovered={hoveredField === 'confirmPassword'}
          setHovered={(val) => setHoveredField(val ? 'confirmPassword' : null)}
        />
        
        {/* Avatar selection */}
        <div className="avatar-selection">
          <label className="label-title">Välj avatar:</label>
          <div className="avatar-options">
            {avatars.map((a, idx) => (
              <label key={idx} className="avatar-option">
                <input
                  id={`avatar-${idx}`}
                  type="radio"
                  name="avatar"
                  value={idx}
                  checked={profile.avatar === idx}
                  onChange={() => setProfile((prev) => ({ ...prev, avatar: idx }))}
                />
                {a.emoji}
              </label>
            ))}
          </div>
        </div>

        {/* Save profile button */}
        <Button
          type="submit"
          label="Spara profil"
          className="invisible-btn"
          disabled={!isFormValid}
        />
      </form>
    </div>
  );
};

export default ProfilePage;
