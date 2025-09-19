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

  // Return to selected level when clicking a highscore card
  const handleLevelClick = (level) => {
    setCurrentLevel(level);
  };

  return (
    <main>
      <div className="highscore-table">
        <div className="highscore-header">
          <span className="header">Level</span>
          <span className="header">Highscore</span>
          <span className="header">Tid</span>
        </div>
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
      </div>
    </main>
  );
};

export default HighscorePage;
