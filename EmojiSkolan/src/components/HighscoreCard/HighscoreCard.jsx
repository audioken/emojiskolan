import React from 'react'
import "./HighscoreCard.css"

function formatTime(seconds) {
  if (!seconds && seconds !== 0) return '';
  const m = Math.floor(seconds / 60);
  const s = seconds % 60;
  return `${m}:${s.toString().padStart(2, '0')}`;
}

const HighscoreCard = ({ level, isUnlocked, rounds, time, onClick, selected }) => {
  return (
    <div
      className={`highscore-row${isUnlocked ? ' unlocked' : ' locked'}${selected ? ' selected' : ''}`}
      onClick={isUnlocked ? onClick : undefined}
      style={{ cursor: isUnlocked ? 'pointer' : 'not-allowed', opacity: isUnlocked ? 1 : 0.5 }}
    >
      <span className="highscore-col level-col">
        {level} {isUnlocked ? '' : <span role="img" aria-label="locked">🔒</span>}
      </span>
      <span className="highscore-col score-col">{isUnlocked && rounds !== undefined ? rounds : '-'}</span>
      <span className="highscore-col time-col">{isUnlocked && time !== undefined ? formatTime(time) : '-'}</span>
    </div>
  );
}

export default HighscoreCard;