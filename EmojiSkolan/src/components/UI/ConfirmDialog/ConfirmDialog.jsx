import './ConfirmDialog.css';
import { createPortal } from 'react-dom';
import { useEffect } from 'react';
import Button from '../Button/Button';

const ConfirmDialog = ({
  isOpen,
  onConfirm,
  onCancel,
  title = 'Bekräfta',
  message,
  confirmText = 'Ja',
  cancelText = 'Avbryt',
}) => {

  useEffect(() => {
    const handleEscape = (e) => {
      if (e.key === 'Escape' && isOpen) {
        onCancel();
      }
    };

    document.addEventListener('keydown', handleEscape);
    return () => document.removeEventListener('keydown', handleEscape);
  }, [isOpen, onCancel]);

  // Prevent background scrolling when dialog is open
  useEffect(() => {
    if (isOpen) {
      document.body.style.overflow = 'hidden';
    } else {
      document.body.style.overflow = 'unset';
    }

    return () => {
      document.body.style.overflow = 'unset';
    };
  }, [isOpen]);

  if (!isOpen) return null;

  const handleBackdropClick = (e) => {
    if (e.target === e.currentTarget) {
      onCancel();
    }
  };

  return createPortal(
    <div className="confirm-backdrop" onClick={handleBackdropClick}>
      <div
        className="confirm-dialog"
        role="dialog"
        aria-modal="true"
        aria-labelledby="confirm-title"
      >
        <div className="confirm-header">
          <h3 id="confirm-title">{title}</h3>
          <Button label={<i className="fa-solid fa-xmark"></i>} className="button button-round" onClick={onCancel} aria-label="Stäng dialog" />
        </div>
        <div className="confirm-body">
          <p>{message}</p>
        </div>
        <div className="confirm-actions">
          <Button label={cancelText} className="button button-cancel" onClick={onCancel} autoFocus />
          <Button label={confirmText} className="button button-confirm" onClick={onConfirm} />
        </div>
      </div>
    </div>,
    document.body
  );
};

export default ConfirmDialog;
