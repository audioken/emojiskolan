import { createContext, useContext, useState } from 'react';
import ConfirmDialog from '../components/UI/ConfirmDialog/ConfirmDialog';

const ConfirmContext = createContext();

export const ConfirmProvider = ({ children }) => {
  const [confirmState, setConfirmState] = useState({
    isOpen: false,
    message: '',
    title: 'Bekräfta',
    confirmText: 'Ja',
    cancelText: 'Avbryt',
    onConfirm: null,
    onCancel: null,
  });

  const confirm = (message, options = {}) => {
    const { title = 'Bekräfta', confirmText = 'Ja', cancelText = 'Avbryt' } = options;

    return new Promise((resolve) => {
      setConfirmState({
        isOpen: true,
        message,
        title,
        confirmText,
        cancelText,
        onConfirm: () => {
          setConfirmState((prev) => ({ ...prev, isOpen: false }));
          resolve(true);
        },
        onCancel: () => {
          setConfirmState((prev) => ({ ...prev, isOpen: false }));
          resolve(false);
        },
      });
    });
  };

  const alert = (message, options = {}) => {
    const { title = 'Information', confirmText = 'OK' } = options;

    return new Promise((resolve) => {
      setConfirmState({
        isOpen: true,
        message,
        title,
        confirmText,
        cancelText: null, // No cancel button for alerts
        onConfirm: () => {
          setConfirmState((prev) => ({ ...prev, isOpen: false }));
          resolve(true);
        },
        onCancel: () => {
          setConfirmState((prev) => ({ ...prev, isOpen: false }));
          resolve(true);
        },
      });
    });
  };

  return (
    <ConfirmContext.Provider value={{ confirm, alert }}>
      {children}
      <ConfirmDialog
        isOpen={confirmState.isOpen}
        message={confirmState.message}
        title={confirmState.title}
        confirmText={confirmState.confirmText}
        cancelText={confirmState.cancelText}
        onConfirm={confirmState.onConfirm}
        onCancel={confirmState.onCancel}
      />
    </ConfirmContext.Provider>
  );
};

export const useConfirmDialog = () => {
  const context = useContext(ConfirmContext);
  if (!context) {
    throw new Error('useConfirmDialog must be used within ConfirmProvider');
  }
  return context;
};
