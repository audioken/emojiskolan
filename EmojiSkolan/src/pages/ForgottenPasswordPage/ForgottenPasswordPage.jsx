import { useState, useEffect } from 'react';
import bcrypt from 'bcryptjs';
import Input from '../../components/UI/Input/Input.jsx';
import Button from '../../components/UI/Button/Button.jsx';
import { useInstruction } from '../../context/InstructionContext';
import generateRandomPassword from '../../utils/generateRandomPassword';
import instructionMessages from '../../utils/instructionMessages';
import './ForgottenPasswordPage.css';

const ForgottenPasswordPage = () => {
  const [email, setEmail] = useState(''); // State for email input
  const { showMessage } = useInstruction(); // Consistent with Board.jsx

  useEffect(() => {
    showMessage(instructionMessages.get('forgottenPasswordPrompt'));
  }, []);

  // Triggered when "Reset Password" button is clicked
  const handleResetPassword = async () => {
    try {
      // 1. Fetch all users
      const res = await fetch('http://localhost:5132/api/users');
      const users = await res.json();

      // 2. Find user by email
      const user = users.find((u) => u.email === email);
      if (!user) {
        showMessage(instructionMessages.get('forgottenPasswordNoUser'));
        return;
      }
      console.log('Resetting password for user:', user);
      // 3. Generate new random password
      const newPassword = generateRandomPassword();

      // 4. Hash it
      const hashedPassword = await bcrypt.hash(newPassword, 10);

      // 5. Update db.json for that user
      await fetch(`http://localhost:5132/api/users/${user.id}/password`, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ passwordHash: hashedPassword }),
      });

      // 6. Display new password in the instruction box
      showMessage(
        `${instructionMessages.get('forgottenPasswordSuccess')} Ditt nya lösenord är: ${newPassword}`
      );
    } catch (err) {
      console.error('Password reset failed:', err);
      showMessage(instructionMessages.get('forgottenPasswordError'));
    }
  };

  return (
    <div className="forgotten-password-container">
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
          <button
            type="button"
            onClick={handleResetPassword}
            className="submit-btn"
            disabled={!email.trim()}
          >
            Återställ lösenord
          </button>
        </div>
      </form>
    </div>
  );
};

export default ForgottenPasswordPage;
