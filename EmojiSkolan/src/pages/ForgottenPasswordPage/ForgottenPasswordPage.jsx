import './ForgottenPasswordPage.css';
import { useState, useEffect } from 'react';
import { useInstruction } from '../../context/InstructionContext';
import Input from '../../components/UI/Input/Input.jsx';
import Button from '../../components/UI/Button/Button.jsx';
import generateRandomPassword from '../../utils/generateRandomPassword';
import instructionMessages from '../../utils/instructionMessages';
import bcrypt from 'bcryptjs';

const ForgottenPasswordPage = () => {
  const [email, setEmail] = useState('');
  const { showMessage } = useInstruction();

  useEffect(() => {
    showMessage(instructionMessages.get('forgottenPasswordPrompt'));
  }, []);

  const handleResetPassword = async () => {
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
      <h2>Glömt lösenord</h2>

      <form className="forgotten-password-form">
        <Input
          className="input-field"
          label="E-post"
          name="email"
          type="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          autoFocus
        />

        <div className="submit-section">
          <Button
            type="button"
            onClick={handleResetPassword}
            className="submit-btn"
            label="Återställ lösenord"
            aria-label="Återställ lösenord"
            title="Återställ lösenord"
            disabled={!email.trim()}
          ></Button>
        </div>
      </form>
    </main>
  );
};

export default ForgottenPasswordPage;
