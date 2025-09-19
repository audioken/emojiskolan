import './TrainingDisplay.css';
import { useResults } from '../../context/ResultContext';
import { useEmoji } from '../../context/EmojiContext';
import { useInstruction } from '../../context/InstructionContext';
import { useEffect } from 'react';
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
    <div className="training-table-container">
      <table className="training-table">
        <thead>
          <tr>
            <th className="training-header-col">Emoji</th>
            <th className="training-header-col">Betydelse</th>
          </tr>
        </thead>
        <tbody>
          {levelEmojis.map((emoji) => (
            <tr className="training-row" key={emoji.id}>
              <td className="training-col emoji-col">{emoji.symbol}</td>
              <td className="training-col meaning-col">{emoji.description}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default TrainingDisplay;
