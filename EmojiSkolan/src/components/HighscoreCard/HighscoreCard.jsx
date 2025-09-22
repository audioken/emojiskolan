import './HighscoreCard.css';
import { formatTimeHighScore } from '../../utils/formatTime';

const HighscoreCard = ({
  level,
  isUnlocked,
  rounds,
  time,
  onClick,
  selected,
  username,
  className,
  isGlobal,
}) => {
  return (
    <tr
      className={`highscore-row${isUnlocked ? ' unlocked' : ' locked'}${selected ? ' selected' : ''} ${className || ''}`}
      onClick={isUnlocked ? onClick : undefined}
      title={
        isGlobal
          ? isUnlocked
            ? `Nivå ${level} - Global bästa (Klicka för att välja nivå)`
            : `Lås upp nivå ${level} genom att klara föregående nivå`
          : isUnlocked
            ? `Välj nivå ${level}`
            : `Lås upp nivå ${level} genom att klara föregående nivå`
      }
    >
      <td className="highscore-col level-col">
        {level}{' '}
        {!isUnlocked ? (
          <span role="img" aria-label="locked">
            🔒
          </span>
        ) : (
          ''
        )}
      </td>

      {isGlobal ? (
        <>
          <td className="highscore-col score-col">{username || '-'}</td>
          <td className="highscore-col score-col">{rounds !== undefined ? rounds : '-'}</td>
        </>
      ) : (
        <>
          <td className="highscore-col score-col">
            {isUnlocked && rounds !== undefined ? rounds : '-'}
          </td>
        </>
      )}
      <td className="highscore-col time-col">
        {(isGlobal && time !== undefined) || (isUnlocked && time !== undefined)
          ? formatTimeHighScore(time)
          : '-'}
      </td>
    </tr>
  );
};

export default HighscoreCard;
