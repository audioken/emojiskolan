import './LoginPage.css';
import { useState, useEffect, useRef } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../../context/AuthContext';
import { useMultiForm } from '../../context/MultiFormContext';
import { useInstruction } from '../../context/InstructionContext';
import instructionMessages from '../../utils/instructionMessages';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';

const LoginPage = () => {
  const { login } = useAuth();
  const { showMessage } = useInstruction();
  const { setFormRef, setFormValidStatus } = useMultiForm();
  const [showPassword, setShowPassword] = useState(false);
  const [formData, setFormData] = useState({
    identifier: '', // Can be either username or email
    password: '',
  });
  const navigate = useNavigate();
  const formRef = useRef();

  useEffect(() => {
    showMessage(instructionMessages.get('login'));
  }, []);

  useEffect(() => {
    setFormRef('login', formRef);
  }, [setFormRef]);

  useEffect(() => {
    const isFormValid = formData.identifier.trim() !== '' && formData.password.trim() !== '';
    setFormValidStatus('login', isFormValid);
  }, [formData, setFormValidStatus]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      await login(formData.identifier, formData.password);
      navigate('/');
    } catch (err) {
      setError(err.message);
    }
  };

  return (
    <main className="login-container">
      <h2>Logga in här</h2>

      <form ref={formRef} onSubmit={handleSubmit} className="login-form">
        <Input
          className="input-field"
          label="Användarnamn eller E-post"
          type="text"
          name="identifier"
          value={formData.identifier}
          onChange={handleChange}
          autoFocus
        />

        <Input
          className="input-field"
          label="Lösenord"
          type={showPassword ? 'text' : 'password'}
          name="password"
          value={formData.password}
          onChange={handleChange}
          showPasswordToggle={true}
          onPasswordToggle={() => setShowPassword((prev) => !prev)}
        />

        <div className="forgot-password-section">
          <Button label="Glömt lösenord?" path="/forgot-password" className="forgot-password-btn" />
        </div>

        {/* Invisible submit button to allow form submission via MultiFormContext */}
        <button type="submit" className="invisible-btn"></button>
      </form>
    </main>
  );
};

export default LoginPage;
