import './ForgottenPasswordPage.css';
import { useState, useEffect, useRef } from 'react';
import { useInstruction } from '../../context/InstructionContext';
import { useMultiForm } from '../../context/MultiFormContext';
import Input from '../../components/UI/Input/Input.jsx';
import generateRandomPassword from '../../utils/generateRandomPassword';
import instructionMessages from '../../utils/instructionMessages';
import bcrypt from 'bcryptjs';

const ForgottenPasswordPage = () => {
  const [email, setEmail] = useState('');
  const { showMessage } = useInstruction();
  const { setFormRef, setFormValidStatus } = useMultiForm();
  const formRef = useRef();

  useEffect(() => {
    showMessage(instructionMessages.get('forgottenPasswordPrompt'));
  }, []);

  useEffect(() => {
    setFormRef('forgottenPassword', formRef);
  }, [setFormRef]);

  useEffect(() => {
    const isValidEmail =
      email.trim() !== '' && /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/.test(email);
    setFormValidStatus('forgottenPassword', isValidEmail);
  }, [email, setFormValidStatus]);

  const handleResetPassword = async (e) => {
    e.preventDefault();
    try {
      const res = await fetch('http://localhost:5132/api/users');
      const users = await res.json();
      const user = users.find((u) => u.email === email);

      if (!user) {
        showMessage(instructionMessages.get('forgottenPasswordNoUser'));
        return;
      }

      const newPassword = generateRandomPassword();
      const hashedPassword = await bcrypt.hash(newPassword, 10);

      await fetch(`http://localhost:5132/api/users/${user.id}/password`, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ passwordHash: hashedPassword }),
      });

      showMessage(
        `${instructionMessages.get('forgottenPasswordSuccess')} Ditt nya lösenord är: ${newPassword}`
      );
    } catch (err) {
      console.error('Password reset failed:', err);
      showMessage(instructionMessages.get('forgottenPasswordError'));
    }
  };

  return (
    <main className="forgotten-password-container">
      <form ref={formRef} onSubmit={handleResetPassword} className="forgotten-password-form">
        <Input
          className="input-field"
          label="E-post"
          name="email"
          type="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          autoFocus
        />

        {/* Invisible submit button to allow form submission via MultiFormContext */}
        <button type="submit" className="invisible-btn"></button>
      </form>
    </main>
  );
};

export default ForgottenPasswordPage;
