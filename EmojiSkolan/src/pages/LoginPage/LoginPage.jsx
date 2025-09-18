import './LoginPage.css';
import { useState, useEffect, useRef } from 'react';
import { useAuth } from '../../context/AuthContext';
import { useMultiForm } from '../../context/MultiFormContext';
import { useInstruction } from '../../context/InstructionContext';
import instructionMessages from '../../utils/instructionMessages';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';

// LoginPage component handles user login form
const LoginPage = () => {
  const { login } = useAuth();
  const { showMessage } = useInstruction();

  useEffect(() => {
    showMessage(instructionMessages.get('login'));
  }, []);

  // Ref and context for multi-form handling
  const formRef = useRef();
  const { setFormRef } = useMultiForm();

  // State for storing input values for identifier (username or email) and password
  const [formData, setFormData] = useState({
    identifier: '', // Can be either username or email
    password: '',
  });

  useEffect(() => {
    setFormRef('login', formRef);
  }, [setFormRef]);

  const [showPassword, setShowPassword] = useState(false);
  const [error, setError] = useState('');
  // Updates formData when user types in any input field
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Handles form submission when user clicks "Login"
  const handleSubmit = async (e) => {
    e.preventDefault(); // Prevents page reload

    try {
      await login(formData.identifier, formData.password); //  call context login
      window.location.href = '/'; // optional redirect after login
    } catch (err) {
      setError(err.message);
    }
  };

  // Render login form
  return (
    <div className="login-container">
      <h2>Logga in här</h2>

      {/* Show error message if exists */}
      {error && <div className="error-message">{error}</div>}

      {/* Login form with two input fields */}
      <form ref={formRef} onSubmit={handleSubmit} className="login-form">
        {/* Identifier input (username or email) */}
        <Input
          className="input-field"
          label="Användarnamn eller E-post"
          type="text"
          name="identifier"
          value={formData.identifier}
          onChange={handleChange}
          autoFocus
        />

        {/* Password input */}
        <div className="password-input-group">
          <Input
            className="input-field"
            label="Lösenord"
            type={showPassword ? 'text' : 'password'}
            name="password"
            value={formData.password}
            onChange={handleChange}
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

        {/* Forgot password link under password field */}
        <div className="forgot-password-section">
          <Button label="Glömt lösenord?" path="/forgot-password" className="forgot-password-btn" />
        </div>

        {/* Invisible submit button to allow form submission via MultiFormContext */}
        <button type="submit" className="invisible-btn"></button>
      </form>
    </div>
  );
};

export default LoginPage;
