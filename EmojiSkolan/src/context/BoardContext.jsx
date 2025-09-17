import { createContext, useContext, useState } from "react";

const BoardContext = createContext();

export const BoardProvider = ({ children }) => {
  const [cards, setCards] = useState([]);
  const [roundCounter, setRoundCounter] = useState(0);
  const [seconds, setSeconds] = useState(0);
  const [timerActive, setTimerActive] = useState(false);

  return (
    <BoardContext.Provider
      value={{
        cards,
        setCards,
        roundCounter,
        setRoundCounter,
        seconds,
        setSeconds,
        timerActive,
        setTimerActive,
      }}
    >
      {children}
    </BoardContext.Provider>
  );
};


export const useBoard = () => useContext(BoardContext);
