import './HighscoreCard.css';
import { formatTimeHighScore } from '../../utils/formatTime';

const HighscoreCard = ({
  level,
  category,
  isUnlocked,
  rounds,
  time,
  onClick,
  selected,
  username,
  className,
  isGlobal,
  currentUser,
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
            ? `Nivå ${level} - Din bästa (Klicka för att välja nivå)`
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
      <td className="highscore-col category-col">{category || '-'}</td>

      {isGlobal ? (
        <>
          <td
            className={`highscore-col score-col username-col${username && currentUser && username === currentUser ? ' highlightedUser' : ''}`}
          >
            {username || '-'}
            {username && currentUser && username === currentUser ? (
              <span role="img" aria-label="pokal" title="Du har rekordet!">
                {' '}
                🏆
              </span>
            ) : null}
          </td>
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
