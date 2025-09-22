import './HighscorePage.css';
import { useEffect, useState } from 'react';
import { useResults } from '../../context/ResultContext';
import { useInstruction } from '../../context/InstructionContext';
import { useAuth } from '../../context/AuthContext';
import HighscoreCard from '../../components/HighscoreCard/HighscoreCard';
import instructionMessages from '../../utils/instructionMessages';

const TOTAL_LEVELS = 10;

const HighscorePage = () => {
  const { bestResults, globalBestResults, currentLevel, setCurrentLevel } = useResults();
  const { showMessage } = useInstruction();
  const [showGlobal, setShowGlobal] = useState(false);
  const { user } = useAuth();

  useEffect(() => {
    showGlobal
      ? showMessage(instructionMessages.get('highscoreGlobal'))
      : showMessage(instructionMessages.get('highscore'));
  }, [showGlobal]);

  const levels = Array.from({ length: TOTAL_LEVELS }, (_, i) => i + 1);

  const handleLevelClick = (level) => {
    setCurrentLevel(level);
  };

  const toggleHighscoreView = () => {
    setShowGlobal(!showGlobal);
  };

  // Use the appropriate results based on the current view
  const currentResults = showGlobal ? globalBestResults : bestResults;

  return (
    <main>
      <div className="highscore-wrapper">
        <div className="highscore-toggle">
          <label className="toggle-label">
            <input
              type="checkbox"
              checked={showGlobal}
              onChange={toggleHighscoreView}
              className="toggle-checkbox"
            />
            <span className="toggle-text">
              {showGlobal ? 'Global highscore' : `${user.username}'s highscore`}
            </span>
          </label>
        </div>

        <table className="highscore-table">
          <thead className="highscore-header">
            <tr>
              <th className="header">Nivå</th>
              {showGlobal && <th className="header">Användare</th>}
              <th className="header">Rundor</th>
              <th className="header">Tid</th>
            </tr>
          </thead>
          <tbody>
            {levels.map((level) => {
              const result = currentResults[level];
              const personalResult = bestResults[level]; // Använd personlig data för låsning

              if (showGlobal) {
                // Global view - använd personlig progress för låsning/upplåsning
                const isUnlocked = level === 1 || !!personalResult;
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
                    username={result?.username}
                    selected={isSelected}
                    isGlobal={true}
                    onClick={isSelectable ? () => handleLevelClick(level) : undefined}
                  />
                );
              } else {
                // Personal view - show level only if unlocked or next to unlock
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
                    isGlobal={false}
                    onClick={isSelectable ? () => handleLevelClick(level) : undefined}
                  />
                );
              }
            })}
          </tbody>
        </table>
      </div>
    </main>
  );
};

export default HighscorePage;
