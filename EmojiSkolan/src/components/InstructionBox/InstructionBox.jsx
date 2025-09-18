import './InstructionBox.css';
import { useInstruction } from '../../context/InstructionContext';
import { useEffect, useState } from 'react';
import Button from '../UI/Button/Button';

const InstructionBox = () => {
  const { message } = useInstruction();
  const [isSpeakingEnabled, setIsSpeakingEnabled] = useState(false);

  // Automatic speech synthesis when message changes
  useEffect(() => {
    if (!message || !isSpeakingEnabled) return;

    // Stop any ongoing speech synthesis
    window.speechSynthesis.cancel();

    const utterance = new SpeechSynthesisUtterance(message);
    utterance.lang = 'sv-SE';
    window.speechSynthesis.speak(utterance);

    return () => window.speechSynthesis.cancel();
  }, [message, isSpeakingEnabled]);

  // Toggle function for the button
  const toggleSpeaking = () => {
    setIsSpeakingEnabled((prev) => !prev);
    window.speechSynthesis.cancel(); // Stop speech synthesis when turning off
  };

  return (
    <aside className="instruction-box">
      <div className="instruction-box-content">{message}</div>
      <Button
        className="speak-button"
        onClick={toggleSpeaking}
        aria-label={isSpeakingEnabled ? 'Stäng av uppläsning' : 'Slå på uppläsning'}
        label={isSpeakingEnabled ? '🔊' : '🔈'}
      ></Button>
    </aside>
  );
};

export default InstructionBox;
