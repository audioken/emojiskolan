import { Routes, Route } from 'react-router-dom';
import { EmojiProvider } from './context/EmojiContext';
import { BoardProvider } from './context/BoardContext';
import { MultiFormProvider } from './context/MultiFormContext';
import { ResultProvider } from './context/ResultContext';
import { InstructionProvider } from './context/InstructionContext';
import Header from './components/Layout/Header/Header';
import Footer from './components/Layout/Footer/Footer';
import StartPage from './pages/StartPage/StartPage';
import LoginPage from './pages/LoginPage/LoginPage';
import ForgottenPasswordPage from './pages/ForgottenPasswordPage/ForgottenPasswordPage';
import RegisterPage from './pages/RegisterPage/RegisterPage';
import ProfilePage from './pages/ProfilePage/ProfilePage';
import HighscorePage from './pages/HighscorePage/HighscorePage';
import TrainingPage from './pages/TrainingPage/TrainingPage';
import InstructionBox from './components/InstructionBox/InstructionBox';
import ProtectedRoute from './components/Auth/ProtectedRoute';
import PageNotFound from './pages/PageNotFound/PageNotFound';

function App() {
  return (
    <div className="app-container">
      <EmojiProvider>
        <BoardProvider>
          <MultiFormProvider>
            <ResultProvider>
              <InstructionProvider>
                <div className="header-instruction-wrapper">
                  <Header />
                  <InstructionBox />
                </div>
                <Routes>
                  <Route path="/" element={<StartPage />} />
                  <Route path="/login" element={<LoginPage />} />
                  <Route path="/forgot-password" element={<ForgottenPasswordPage />} />
                  <Route path="/register" element={<RegisterPage />} />

                  <Route
                    path="/profile"
                    element={
                      <ProtectedRoute>
                        <ProfilePage />
                      </ProtectedRoute>
                    }
                  />
                  <Route
                    path="/highscore"
                    element={
                      <ProtectedRoute>
                        <HighscorePage />
                      </ProtectedRoute>
                    }
                  />
                  <Route
                    path="/training"
                    element={
                      <ProtectedRoute>
                        <TrainingPage />
                      </ProtectedRoute>
                    }
                  />

                  {/* Catch-all */}
                  <Route path="*" element={<PageNotFound />} />
                </Routes>
              </InstructionProvider>
              <Footer />
            </ResultProvider>
          </MultiFormProvider>
        </BoardProvider>
      </EmojiProvider>
    </div>
  );
}

export default App;
