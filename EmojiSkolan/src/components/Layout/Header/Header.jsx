import './Header.css';
import logo from '../../../public/images/logo.svg';
import { useNavigate } from 'react-router-dom';
import { useResults } from '../../../context/ResultContext';
import { useAuth } from '../../../context/AuthContext';
import { useGameProtection } from '../../../hooks/useGameProtection';
import { formatTime } from '../../../utils/formatTime';
import { avatars } from '../../../utils/avatars.js';

function Header() {
  const { user } = useAuth();
  const { bestResults, currentLevel } = useResults();
  const { protectedAction } = useGameProtection();
  const navigate = useNavigate();

  const protectedNavigateToHighscore = protectedAction(
    () => navigate('/highscore'),
    'Ett spel pågår! Vill du verkligen gå till highscore?'
  );

  const username = user ? user.username : '';
  const avatarId = user ? user.avatar : '';
  const avatar = avatarId !== '' ? avatars[avatarId].emoji : '👤';

  const currentBest = bestResults[currentLevel];

  const timeString = currentBest ? formatTime(currentBest.time) : '-';
  const roundsString = currentBest ? currentBest.rounds : '-';

  return (
    <header className="header-top">
      {!user ? (
        <div
          className="start-content"
          aria-label="Sidhuvud som länkar till startsidan"
          title="Gå till startsidan"
        >
          <img src={logo} alt="Logo" className="header-logo" onClick={() => navigate('/')} />
          <h1 className="header-title">EmojiSkolan</h1>
        </div>
      ) : (
        <div
          className="summary-content"
          aria-label="Sammanfattning av bästa resultat, nivå och användare. Klicka för att gå till highscore."
          title="Gå till highscore"
          onClick={() => {
            if (window.location.pathname === '/highscore') {
              navigate('/');
            } else {
              protectedNavigateToHighscore();
            }
          }}
        >
          <div className="summary-fields">
            <fieldset>
              <legend className="fieldset-title best-result">Bästa Resultat</legend>
              <span className="fieldset-content">
                {roundsString} rundor / {timeString} min
              </span>
            </fieldset>
            <fieldset>
              <legend className="fieldset-title level">Nivå</legend>
              <span className="fieldset-content">{currentLevel}</span>
            </fieldset>
            <fieldset>
              <legend className="fieldset-title avatar">{avatar}</legend>
              <span className="fieldset-content">{username}</span>
            </fieldset>
          </div>
        </div>
      )}
    </header>
  );
}

export default Header;
