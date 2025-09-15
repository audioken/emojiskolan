import { createContext, useContext, useState } from "react";

const BoardContext = createContext();

export const BoardProvider = ({ children }) => {
  const [cards, setCards] = useState([]);
  const [roundCounter, setRoundCounter] = useState(0);
  const [seconds, setSeconds] = useState(0);

  return (
    <BoardContext.Provider
      value={{
        cards,
        setCards,
        roundCounter,
        setRoundCounter,
        seconds,
        setSeconds,
      }}
    >
      {children}
    </BoardContext.Provider>
  );
};
// ...existing code...

export const useBoard = () => useContext(BoardContext);
