import './TrainingDisplay.css';
import { useResults } from '../../context/ResultContext';
import { useEmoji } from '../../context/EmojiContext';
import { useInstruction } from '../../context/InstructionContext';
import { useState, useEffect } from 'react';
import instructionMessages from '../../utils/instructionMessages';

function TrainingDisplay() {
  const { currentLevel } = useResults();
  const { allEmojis } = useEmoji();
  const { showMessage } = useInstruction();

  // Filter emojis for the current level
  const levelEmojis = allEmojis.filter((emoji) => emoji.levelId === currentLevel);

  useEffect(() => {
    showMessage(instructionMessages.get('training'));
  }, [currentLevel]);

  return (
    <div className="training-display">
      <table>
        <thead>
          <tr>
            <th>Emoji</th>
            <th>Betydelse</th>
          </tr>
        </thead>
        <tbody>
          {levelEmojis.map((emoji) => (
            <tr key={emoji.id}>
              <td>{emoji.symbol}</td>
              <td>{emoji.description}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default TrainingDisplay;
