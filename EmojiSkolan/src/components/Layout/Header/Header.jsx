import "./Header.css";
import logo from "../../../public/images/logo.svg";
import { useResults } from "../../../context/ResultContext";
import { formatTime } from "../../../utils/formatTime";
import { avatars } from "../../../utils/avatars.js";
import { useAuth } from "../../../context/AuthContext";
import { useNavigate } from "react-router-dom";

function Header() {
  const { user } = useAuth(); // 👈 get logged-in user
  const navigate = useNavigate();

  const username = user ? user.username : "";
  const avatarId = user ? user.avatar : "";

  // Hämta rätt avatar från listan baserat på avatarid:
  const avatar = avatarId !== "" ? avatars[avatarId].emoji : "👤";

  // Get the best result and current level
  const { bestResults, currentLevel } = useResults();

  // Hämta rekord för aktuell nivå
  const currentBest = bestResults[currentLevel];
  // Format the time string
  const timeString = currentBest ? formatTime(currentBest.time) : "-";
  const roundsString = currentBest ? currentBest.rounds : "-";

  return (
    <div className="header-top">
      {!user ? (
        <div className="start-content">
          <img src={logo} alt="Logo" style={{ cursor: "pointer" }} onClick={() => navigate("/")} />
          <h1 className="header-title">EmojiSkolan</h1>
        </div>
      ) : (
        <div
          className="summary-content"
          style={{ cursor: "pointer" }}
          onClick={() => {
            if (window.location.pathname === "/highscore") {
              navigate("/");
            } else {
              navigate("/highscore");
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
    </div>
  );
}

export default Header;
