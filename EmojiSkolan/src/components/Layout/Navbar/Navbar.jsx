import './Navbar.css';
import '../../UI/Button/Button.css';
import { useAuth } from '../../../context/AuthContext';
import { useResults } from '../../../context/ResultContext';
import { useLocation, useNavigate } from 'react-router-dom';
import { useMultiForm } from '../../../context/MultiFormContext';
import { useGameProtection } from '../../../hooks/useGameProtection';
import Button from '../../UI/Button/Button';
import LevelNavigation from '../../LevelNavigation/LevelNavigation';

const Navbar = () => {
  const { user, logout } = useAuth();
  const { currentLevel } = useResults();
  const { submitForm, formValid } = useMultiForm();
  const navigate = useNavigate();
  const { protectedAction } = useGameProtection();
  const location = useLocation();

  // Protected actions to prevent navigation or logout during an active game
  const protectedLogout = protectedAction(logout, 'Ett spel pågår! Vill du verkligen logga ut?');
  const protectedNavigateToProfile = protectedAction(
    () => navigate('/profile'),
    'Ett spel pågår! Vill du verkligen gå till profilen?'
  );
  const protectedNavigateToLogin = protectedAction(
    () => navigate('/login'),
    'Ett spel pågår! Vill du verkligen gå till inloggningen?'
  );
  const protectedNavigateToRegister = protectedAction(
    () => navigate('/register'),
    'Ett spel pågår! Vill du verkligen gå till registreringen?'
  );
  const protectedNavigateToTraining = protectedAction(
    () => navigate('/training'),
    'Ett spel pågår! Vill du verkligen gå till träningen?'
  );

  // Configuration for which buttons to show based on the current route and user state
  const navConfig = {
    '/login': !user
      ? ['back-to-start', 'login-submit', 'register-navigate']
      : ['profile', 'logout'],
    '/register': !user
      ? ['back-to-start', 'login-navigate', 'register-submit']
      : ['profile', 'logout'],
    '/profile': ['back-to-start', 'profile-submit', 'logout'],
    '/highscore': ['profile', currentLevel ? 'goToLevel' : null, 'logout'],
    '/': user
      ? ['training-navigate', 'profile', 'levelNavigation', 'logout']
      : ['login-navigate', 'register-navigate'],
    '/forgot-password': !user
      ? ['back-to-start', 'login-navigate', 'register-navigate']
      : ['profile', 'logout'],
    '/training': user
      ? ['back-to-start', 'levelNavigation', 'logout']
      : ['login-navigate', 'register-navigate'],
    '*': !user ? ['back-to-start'] : ['back-to-start'],
  };

  const buttonsToShow = navConfig[location.pathname] ?? navConfig['*'];

  return (
    <nav className="footer-nav">
      {buttonsToShow.includes('training-navigate') && (
        <div className="training-wrapper">
          <Button label="Träning" className="button" onClick={protectedNavigateToTraining} />
        </div>
      )}
      <div className="btns-nav">
        {buttonsToShow.includes('back-to-start') && (
          <Button label="↶ Hem" path="/" className="button" />
        )}
        {buttonsToShow.includes('login-navigate') && (
          <Button label="Logga in" className="button" onClick={protectedNavigateToLogin} />
        )}
        {buttonsToShow.includes('login-submit') && (
          <Button label="Logga in" className="button" onClick={() => submitForm('login')} />
        )}
        {buttonsToShow.includes('register-navigate') && (
          <Button label="Registrera" className="button" onClick={protectedNavigateToRegister} />
        )}
        {buttonsToShow.includes('register-submit') && (
          <Button label="Registrera" className="button" onClick={() => submitForm('register')} />
        )}
        {buttonsToShow.includes('profile-submit') && (
          <Button
            label="Spara profil"
            className="button"
            onClick={() => submitForm('profile')}
            disabled={!formValid.profile}
          />
        )}
        {buttonsToShow.includes('goToLevel') && (
          <Button label={`↶ Gå till nivå ${currentLevel}`} path="/" className="button" />
        )}
        {buttonsToShow.includes('profile') && (
          <Button label="Profil" className="button" onClick={protectedNavigateToProfile} />
        )}
        {buttonsToShow.includes('levelNavigation') && <LevelNavigation />}
        {buttonsToShow.includes('logout') && (
          <Button label="Logga ut" onClick={protectedLogout} className="button" path="/" />
        )}
      </div>
    </nav>
  );
};

export default Navbar;
