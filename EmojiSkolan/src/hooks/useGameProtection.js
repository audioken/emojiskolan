import { useBoard } from '../context/BoardContext';

export const useGameProtection = () => {
  const { timerActive } = useBoard();

  const protectedAction = (action, message = "Ett spel pågår! Vill du verkligen fortsätta?") => {
    return () => {
      if (timerActive && !confirm(message)) {
        return;
      }
      action();
    };
  };

  return { protectedAction, timerActive };
};