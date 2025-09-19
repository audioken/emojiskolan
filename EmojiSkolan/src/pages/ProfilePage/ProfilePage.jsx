import './ProfilePage.css';
import { useEffect, useState, useRef } from 'react';
import { useAuth } from '../../context/AuthContext';
import { useMultiForm } from '../../context/MultiFormContext';
import { useInstruction } from '../../context/InstructionContext';
import { validateInputs } from '../../utils/validateInputs';
import { avatars } from '../../utils/avatars';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';
import instructionMessages from '../../utils/instructionMessages';
import bcrypt from 'bcryptjs';

const ProfilePage = () => {
  const { user, updateUser } = useAuth();
  const { showMessage } = useInstruction();
  const { setFormRef, setFormValidStatus } = useMultiForm();

  const [errors, setErrors] = useState({});
  const [valid, setValid] = useState({});
  const [hoveredField, setHoveredField] = useState(null);
  const [serverError, setServerError] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);
  const [profile, setProfile] = useState({
    username: user?.username || '',
    email: user?.email || '',
    password: '',
    confirmPassword: '',
    avatar: user?.avatar ?? 0,
  });

  const formRef = useRef();

  useEffect(() => {
    showMessage(instructionMessages.get('profile'));
  }, []);

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

  useEffect(() => {
    setFormRef('profile', formRef);
  }, [setFormRef]);

  useEffect(() => {
    const { errors, valid } = validateInputs(profile, 'profile');
    setErrors(errors);
    setValid(valid);

    const isFormValid = Object.values(valid).every(Boolean);
    setFormValidStatus('profile', isFormValid);
  }, [profile, setFormValidStatus]);

  useEffect(() => {
    const passwordFilled = profile.password || profile.confirmPassword;
    setFormValidStatus('profilePasswordFilled', !!passwordFilled);
  }, [profile.password, profile.confirmPassword, setFormValidStatus]);

  function handleChange(e) {
    const { name, value } = e.target;
    setProfile((prev) => ({
      ...prev,
      [name]: value,
    }));
  }

  const handleSubmit = async (e) => {
    e.preventDefault();
    setServerError('');

    const updatedUser = {
      id: user.id,
      username: profile.username,
      email: profile.email,
      avatarId: profile.avatar,
    };

    if (profile.password) {
      const hashedPassword = await bcrypt.hash(profile.password, 10);
      updatedUser.passwordHash = hashedPassword;
    }

    try {
      const res = await fetch('http://localhost:5132/api/users');
      const users = await res.json();

      const exists = users.find(
        (existingUser) =>
          existingUser.id !== user.id &&
          (existingUser.username === profile.username || existingUser.email === profile.email)
      );

      if (exists) {
        setServerError('Användarnamn eller e-post är redan registrerat.');
        return;
      }

      const response = await fetch(`http://localhost:5132/api/users/${user.id}`, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(updatedUser),
      });

      if (response.ok) {
        alert('Profilen är uppdaterad!');

        setProfile((prev) => ({
          ...prev,
          password: '',
          confirmPassword: '',
        }));
        if (typeof updateUser === 'function') {
          const updatedUserFromServer = await response.json();
          updateUser({
            ...updatedUserFromServer,
            avatar: updatedUserFromServer.avatarId,
          });
        }
      } else {
        setServerError('Misslyckades med att uppdatera profilen. Försök igen.');
      }
    } catch (err) {
      console.error('Profiluppdatering misslyckades:', err);
      alert('Profiluppdatering misslyckades!');
    }
  };

  return (
    <main className="profile-container">
      <h2>Profil</h2>

      {serverError && <div className="error-message">{serverError}</div>}

      <form ref={formRef} onSubmit={handleSubmit} className="profile-form">
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

        <div className="password-input-group">
          <Input
            className="input-field"
            label="Lösenord"
            type={showPassword ? 'text' : 'password'}
            name="password"
            value={profile.password}
            onChange={handleChange}
            onClear={() => setProfile((prev) => ({ ...prev, password: '' }))}
            error={errors.password}
            valid={valid.password}
            hovered={hoveredField === 'password'}
            setHovered={(val) => setHoveredField(val ? 'password' : null)}
          />
          <Button
            type="button"
            onClick={() => setShowPassword((prev) => !prev)}
            className="password-toggle-btn"
            tabIndex={-1}
            label={showPassword ? 'Dölj' : 'Visa'}
          />
        </div>

        <div className="password-input-group">
          <Input
            className="input-field"
            label="Bekräfta lösenord"
            type={showConfirmPassword ? 'text' : 'password'}
            name="confirmPassword"
            value={profile.confirmPassword}
            onChange={handleChange}
            onClear={() => setProfile((prev) => ({ ...prev, confirmPassword: '' }))}
            error={errors.confirmPassword}
            valid={valid.confirmPassword}
            hovered={hoveredField === 'confirmPassword'}
            setHovered={(val) => setHoveredField(val ? 'confirmPassword' : null)}
          />
          <Button
            type="button"
            onClick={() => setShowConfirmPassword((prev) => !prev)}
            className="password-toggle-btn"
            tabIndex={-1}
            label={showConfirmPassword ? 'Dölj' : 'Visa'}
          ></Button>
        </div>

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

        {/* Invisible submit button to allow form submission via MultiFormContext */}
        <button type="submit" className="invisible-btn" />
      </form>
    </main>
  );
};

export default ProfilePage;
