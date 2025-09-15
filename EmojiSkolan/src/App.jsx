import { Routes, Route } from "react-router-dom";
import { InstructionProvider } from "./context/InstructionContext";
import { ResultProvider } from "./context/ResultContext";
import { MultiFormProvider } from "./context/MultiFormContext";
import { EmojiProvider } from "./context/EmojiContext";
import { BoardProvider } from "./context/BoardContext";
import StartPage from "./pages/StartPage/StartPage";
import RegisterPage from "./pages/RegisterPage/RegisterPage";
import HighscorePage from "./pages/HighscorePage/HighscorePage";
import ProfilePage from "./pages/ProfilePage/ProfilePage";
import LoginPage from "./pages/LoginPage/LoginPage";
import InstructionBox from "./components/InstructionBox/InstructionBox";
import Header from "./components/Layout/Header/Header";
import Footer from "./components/Layout/Footer/Footer";
import ForgottenPasswordPage from "./pages/ForgottenPasswordPage/ForgottenPasswordPage";

function App() {
  return (
    <div className="app-container">
      <EmojiProvider>
        <BoardProvider>
          <MultiFormProvider>
            <ResultProvider>
              <Header />
              <InstructionProvider>
                <InstructionBox />
                <Routes>
                  <Route path="/" element={<StartPage />} />
                  <Route path="/register" element={<RegisterPage />} />
                  <Route path="/login" element={<LoginPage />} />
                  <Route path="/highscore" element={<HighscorePage />} />
                  <Route path="/profile" element={<ProfilePage />} />
                  <Route
                    path="/forgot-password"
                    element={<ForgottenPasswordPage />}
                  />
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
