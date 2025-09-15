import './Board.css';
import { useState, useEffect } from 'react';
import { createShuffledCards } from '../../utils/helpers';
import { useInstruction } from '../../context/InstructionContext';
import { useResults } from '../../context/ResultContext';
import { formatTime } from '../../utils/formatTime';
import { useAuth } from '../../context/AuthContext';
import { useEmoji } from '../../context/EmojiContext';
import { useBoard } from '../../context/BoardContext';
import Card from '../Card/Card';
import Button from '../UI/Button/Button';
import instructionMessages from '../../utils/instructionMessages';

function Board({}) {
  const { user } = useAuth();
  const { showMessage } = useInstruction();
  const { currentLevel, updateBestResult } = useResults();
  const { allEmojis } = useEmoji();
  const { cards, setCards, roundCounter, setRoundCounter, seconds, setSeconds } = useBoard();

  const [firstCard, setFirstCard] = useState(null);
  const [disableClick, setDisableClick] = useState(false);
  const [timerActive, setTimerActive] = useState(false);

  // Keep track of the game state
  const isGameWon = cards.length > 0 && cards.every((card) => card.isMatched);

  // Displays correct colors for matching cards when game is won
  const displayCards = isGameWon ? cards.map((card) => ({ ...card, isGameWon: true })) : cards;

  // Lägg till en state-flagga
  const [gameWon, setGameWon] = useState(false);

  // När korten uppdateras, kolla om spelet är klart
  useEffect(() => {
    if (cards.length > 0 && cards.every((c) => c.isMatched)) {
      setTimerActive(false);
      setGameWon(true);
    }
  }, [cards]);

  // Reagera på att spelet är vunnet
  useEffect(() => {
    if (gameWon && roundCounter > 0) {
      if (user) {
        updateBestResult(roundCounter, seconds, currentLevel, user.id);
        showMessage(instructionMessages.get('gameWon'));
      } else {
        showMessage(instructionMessages.get('pleaseRegister'));
        localStorage.setItem(
          'lastResult',
          JSON.stringify({
            rounds: roundCounter,
            time: seconds,
            level: currentLevel,
          })
        );
      }
    }
  }, [gameWon]);

  // Keep track of the timer
  useEffect(() => {
    let interval;
    if (timerActive) {
      interval = setInterval(() => setSeconds((s) => s + 1), 1000);
    }
    return () => clearInterval(interval);
  }, [timerActive]);

  // Setup a new game when emojis are loaded or level changes
  useEffect(() => {
    if (allEmojis.length > 0) {
      console.log('det finns något i emojislistan: ', allEmojis);
      setupNewGame();
    }
  }, [currentLevel, allEmojis]);

  // Setup a new game and reset all relevant state
  const setupNewGame = () => {
    setDisableClick(true);
    setTimerActive(false);
    setGameWon(false);

    // Reset all cards
    setTimeout(() => {
      setCards((prev) =>
        prev.map((card) => ({
          ...card,
          isTurnedOver: false,
          isMatched: false,
          isGameWon: false,
        }))
      );
    }, 200);

    // Delayed so cards have time to reset visually
    setTimeout(() => {
      setRoundCounter(0);
      setSeconds(0);
      setFirstCard(null);
      setCards(createShuffledCards(allEmojis, currentLevel));
      setDisableClick(false);
      // Visa rätt meddelande beroende på om användare är inloggad
      if (!user) {
        showMessage(instructionMessages.get('welcomeGuest'));
      } else {
        showMessage(instructionMessages.get('newGame'));
      }
    }, 600);
  };

  // Resets the round
  const resetRound = () => {
    setFirstCard(null);
  };

  const handleCardClick = (clickedCard) => {
    // Prevent action if card is already matched or turned over
    if (clickedCard.isMatched || clickedCard.isTurnedOver || disableClick) return;

    // Turn over the clicked card
    setCards(cards.map((c) => (c === clickedCard ? { ...c, isTurnedOver: true } : c)));

    // Set the first card if it's not already set
    if (!firstCard) {
      if (!timerActive) {
        setTimerActive(true); // Start the timer when the first card is clicked
      }
      setFirstCard(clickedCard);
      showMessage(instructionMessages.get('selectCard'));
    } else {
      const first = firstCard;
      setRoundCounter((r) => r + 1);
      setDisableClick(true); // Disable further clicks until the turn is resolved

      // Check for a match
      if (first.id === clickedCard.id && first.type !== clickedCard.type) {
        showMessage(instructionMessages.get('matchSuccess'));
        setCards((prev) =>
          prev.map((c) => (c.id === clickedCard.id ? { ...c, isMatched: true } : c))
        );
        resetRound();
        setDisableClick(false);
      } else {
        // Wrong match, both cards flash red
        showMessage(instructionMessages.get('matchFail'));
        setCards((prev) =>
          prev.map((c) =>
            (c.id === first.id && c.type === first.type) ||
            (c.id === clickedCard.id && c.type === clickedCard.type)
              ? { ...c, flashWrong: true }
              : c
          )
        );
        setTimeout(() => {
          setCards((prev) =>
            prev.map((c) =>
              (c.id === first.id && c.type === first.type) ||
              (c.id === clickedCard.id && c.type === clickedCard.type)
                ? { ...c, isTurnedOver: false, flashWrong: false }
                : c
            )
          );
          setFirstCard(null);
          setDisableClick(false);
        }, 1400); // Delay for visual feedback
      }
    }
  };

  return (
    <div className="board-container">
      <div className="scoreboard">
        <div className="stats">
          <p className="tries">Antal försök: {roundCounter}</p>
          <p className="timer">Tid: {formatTime(seconds)}</p>
          <Button label="Omstart" className="button" onClick={setupNewGame} />
        </div>
      </div>
      <div className="board">
        {displayCards.map((card, i) => (
          <Card key={i} card={card} onClick={() => handleCardClick(card)} />
        ))}
      </div>
    </div>
  );
}

export default Board;
