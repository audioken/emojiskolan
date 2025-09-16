import { useEffect } from 'react';
import { useResults } from '../../context/ResultContext'
import { useInstruction } from '../../context/InstructionContext';
import instructionMessages from '../../utils/instructionMessages';
import HighscoreCard from '../../components/HighscoreCard/HighscoreCard'
import "./HighscorePage.css"

const TOTAL_LEVELS = 10;

const HighscorePage = () => {
  const { bestResults, currentLevel, setCurrentLevel } = useResults();
  const { showMessage } = useInstruction();

  // Show instruction message on component mount
  useEffect(() => {
    showMessage(instructionMessages.get('highscore'));
  }, []);

  const levels = Array.from({ length: TOTAL_LEVELS }, (_, i) => i + 1);

  //Back to startpage when choosing a level
  const handleLevelClick = (level) => {
    setCurrentLevel(level);
  };

  return (
    <div>
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
    </div>
  );
}

export default HighscorePage