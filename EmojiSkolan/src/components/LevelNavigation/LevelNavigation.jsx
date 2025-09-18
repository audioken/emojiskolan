import "./LevelNavigation.css";
import { useResults } from "../../context/ResultContext";
import { useGameProtection } from "../../hooks/useGameProtection";
import Button from "../UI/Button/Button";

function LevelNavigation() {
  const { bestResults, currentLevel, setCurrentLevel } = useResults();
  const { protectedAction } = useGameProtection();
  
  const records = bestResults || {};
  const isCurrentLevelCompleted = !!records[currentLevel];

  return (
    <div className="level-navigation">
      <Button
        className="button lvl-nav"
        label={`🡄`}
        onClick={protectedAction(
          () => setCurrentLevel(Math.max(1, currentLevel - 1)),
          'Ett spel pågår! Vill du verkligen byta nivå?'
        )}
        disabled={currentLevel === 1}
      />
      <div className="level-indicator">
        <span>Nivå</span>
        <span>{currentLevel}</span>
      </div>
      <Button
        className="button lvl-nav"
        label={isCurrentLevelCompleted ? `🡆` : `🡆🔒`}
        onClick={protectedAction(
          () => setCurrentLevel(Math.min(10, currentLevel + 1)),
          'Ett spel pågår! Vill du verkligen byta nivå?'
        )}
        disabled={!isCurrentLevelCompleted}
      />
    </div>
  );
}

export default LevelNavigation;