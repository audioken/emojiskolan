import './HighscorePage.css';
import { useEffect } from 'react';
import { useResults } from '../../context/ResultContext';
import { useInstruction } from '../../context/InstructionContext';
import HighscoreCard from '../../components/HighscoreCard/HighscoreCard';
import instructionMessages from '../../utils/instructionMessages';

const TOTAL_LEVELS = 10;

const HighscorePage = () => {
  const { bestResults, currentLevel, setCurrentLevel } = useResults();
  const { showMessage } = useInstruction();

  useEffect(() => {
    showMessage(instructionMessages.get('highscore'));
  }, []);

  const levels = Array.from({ length: TOTAL_LEVELS }, (_, i) => i + 1);

  const handleLevelClick = (level) => {
    setCurrentLevel(level);
  };

  return (
    <main>
      <div className="highscore-wrapper">
        <table className="highscore-table">
          <thead className="highscore-header">
            <tr>
              <th className="header">Level</th>
              <th className="header">Highscore</th>
              <th className="header">Tid</th>
            </tr>
          </thead>
          <tbody>
            {levels.map((level) => {
              const result = bestResults[level];
              const isUnlocked = level === 1 || !!result;
              const isNextUnlocked = !!bestResults[level - 1] && !isUnlocked;
              const isSelectable = isUnlocked || isNextUnlocked;
              const isSelected = currentLevel === level;
              return (
                <HighscoreCard
                  key={level}
                  level={level}
                  isUnlocked={isUnlocked || isNextUnlocked}
                  rounds={result?.rounds}
                  time={result?.time}
                  selected={isSelected}
                  onClick={isSelectable ? () => handleLevelClick(level) : undefined}
                />
              );
            })}
          </tbody>
        </table>
      </div>
    </main>
  );
};

export default HighscorePage;
