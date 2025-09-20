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
  const { protectedAction } = useGameProtection();
  const navigate = useNavigate();
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
    '/login': !user ? ['back-to-start', 'login-submit'] : ['profile', 'logout'],
    '/register': !user ? ['back-to-start', 'register-submit'] : ['profile'],
    '/profile': ['back-to-start', 'profile-submit', 'logout'],
    '/highscore': ['profile', currentLevel ? 'goToLevel' : null],
    '/': user
      ? ['training-navigate', 'profile', 'levelNavigation']
      : ['login-navigate', 'register-navigate'],
    '/forgot-password': !user
      ? ['back-to-start', 'login-navigate', 'forgot-password-submit']
      : ['profile', 'logout'],
    '/training': ['back-to-start', 'levelNavigation'],
    '*': !user ? ['back-to-start'] : ['back-to-start'],
  };

  const buttonsToShow = navConfig[location.pathname] ?? navConfig['*'];

  return (
    <nav className="footer-nav">
      <div className="btns-nav">
        {buttonsToShow.includes('back-to-start') && (
          <Button
            label="↶ Hem"
            path="/"
            className="button"
            aria-label="Gå tillbaka till startsidan"
            title="Gå tillbaka till startsidan"
          />
        )}
        {buttonsToShow.includes('login-navigate') && (
          <Button
            label={<><i className="fa-solid fa-right-to-bracket"></i> Logga in</>}
            className="button"
            aria-label="Gå till inloggningen"
            title="Gå till inloggningen"
            onClick={protectedNavigateToLogin}
          />
        )}
        {buttonsToShow.includes('login-submit') && (
          <Button
            label={<><i className="fa-solid fa-right-to-bracket"></i> Logga in</>}
            className="button"
            aria-label="Klicka här för att logga in"
            title="Klicka här för att logga in"
            disabled={!formValid.login}
            onClick={() => submitForm('login')}
          />
        )}
        {buttonsToShow.includes('register-navigate') && (
          <Button
            label={<><i className="fa-solid fa-address-card"></i> Registrera</>}
            className="button"
            aria-label="Gå till registreringen"
            title="Gå till registreringen"
            onClick={protectedNavigateToRegister}
          />
        )}
        {buttonsToShow.includes('register-submit') && (
          <Button
            label={<><i className="fa-solid fa-address-card"></i> Registrera</>}
            className="button"
            aria-label="Klicka här för att registrera"
            title="Klicka här för att registrera"
            disabled={!formValid.register}
            onClick={() => submitForm('register')}
          />
        )}
        {buttonsToShow.includes('profile-submit') && (
          <Button
            label={<><i className="fa-solid fa-floppy-disk"></i> Spara profil</>}
            className="button"
            aria-label="Klicka här för att spara profilen"
            title="Klicka här för att spara profilen"
            disabled={!formValid.profile || !formValid.profilePasswordFilled}
            onClick={() => submitForm('profile')}
          />
        )}
        {buttonsToShow.includes('goToLevel') && (
          <Button
            label={`↶ Gå till nivå ${currentLevel}`}
            path="/"
            className="button"
            aria-label={`Gå till nivå ${currentLevel}`}
            title={`Gå till nivå ${currentLevel}`}
          />
        )}
        {buttonsToShow.includes('profile') && (
          <Button
            label={<><i className="fa-solid fa-user"></i> Profil</>}
            className="button"
            aria-label="Gå till profilen"
            title="Gå till profilen"
            onClick={protectedNavigateToProfile}
          />
        )}
        {buttonsToShow.includes('levelNavigation') && <LevelNavigation />}
        {buttonsToShow.includes('logout') && (
          <Button
            label={<><i className="fa-solid fa-right-from-bracket flip-horizontal"></i> Logga ut</>}
            onClick={protectedLogout}
            className="button"
            path="/"
            aria-label="Klicka här för att logga ut"
            title="Klicka här för att logga ut"
          />
        )}
        {buttonsToShow.includes('forgot-password-submit') && (
          <Button
            className="button"
            label="Återställ lösenord"
            aria-label="Återställ lösenord"
            onClick={() => submitForm('forgottenPassword')}
            title="Återställ lösenord"
            disabled={!formValid.forgottenPassword}
          />
        )}
        {buttonsToShow.includes('training-navigate') && (
          <Button
            label={<><i className="fa-solid fa-graduation-cap"></i> Träning</>}
            className="button"
            aria-label="Gå till träningssidan"
            title="Gå till träningssidan"
            onClick={protectedNavigateToTraining}
          />
        )}
      </div>
    </nav>
  );
};

export default Navbar;
