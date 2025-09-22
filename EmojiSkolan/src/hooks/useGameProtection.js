// import { useBoard } from '../context/BoardContext';

// export const useGameProtection = () => {
//   const { timerActive } = useBoard();

//   const protectedAction = (action, message = "Ett spel pågår! Vill du verkligen fortsätta?") => {
//     return () => {
//       if (timerActive && !confirm(message)) {
//         return;
//       }
//       action();
//     };
//   };

//   return { protectedAction, timerActive };
// };

// hooks/useGameProtection.js
import { useBoard } from '../context/BoardContext';
import { useConfirmDialog } from '../context/ConfirmContext';

export const useGameProtection = () => {
  const { timerActive } = useBoard();
  const { confirm } = useConfirmDialog();

  const protectedAction = (
    action, 
    message = "Ett spel pågår! Vill du verkligen fortsätta?",
    options = {}
  ) => {
    return async () => {
      if (timerActive) {
        const confirmed = await confirm(message, {
          title: 'Varning',
          confirmText: 'Ja, fortsätt',
          cancelText: 'Nej, stanna kvar',
          ...options
        });
        
        if (!confirmed) return;
      }
      action();
    };
  };

  return { protectedAction, timerActive };
};