
import "./LevelNavigation.css";
import { useResults } from "../../context/ResultContext";
import Button from "../UI/Button/Button";

function LevelNavigation() {
  const { bestResults, currentLevel, setCurrentLevel } = useResults();
  const records = bestResults || {};

  const isCurrentLevelCompleted = !!records[currentLevel];

  return (
    <div className="level-navigation">
      {currentLevel > 1 && (
        <Button
          
          label={`🡄`}
          onClick={() => setCurrentLevel(Math.max(1, currentLevel - 1))}
        />
      )}
      <div className="level-indicator">
        <span>Nivå</span>
        <span>{currentLevel}</span>
      </div>
      <Button
        
        label={isCurrentLevelCompleted ? `🡆` : `🡆🔒`}
        onClick={() => {
          if (isCurrentLevelCompleted)
            setCurrentLevel(Math.min(10, currentLevel + 1));
        }}
        disabled={!isCurrentLevelCompleted}
      />
    </div>
  );
}

export default LevelNavigation;