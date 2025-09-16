import React from 'react';
import './FlashingArrow.css';

const FlashingArrow = ({ direction = 'down', size = 32, image = false }) => {
  // Om image är true, använd BlueArrow.png från public/images
  if (image) {
    // Rotera bilden beroende på direction
    const rotation = {
      right: '0deg',
      down: '90deg',
      left: '180deg',
      up: '-90deg',
    }[direction] || '0deg';
    return (
      <img
        src={process.env.PUBLIC_URL ? process.env.PUBLIC_URL + '/images/BlueArrow.png' : '/images/BlueArrow.png'}
        alt={`Pil ${direction}`}
        className={`flashing-arrow flashing-arrow-img`}
        style={{ width: size, height: size, transform: `rotate(${rotation})` }}
      />
    );
  }

  // Annars fallback till emoji
  const arrows = {
    down: '⬇️',
    up: '⬆️',
    left: '⬅️',
    right: '➡️',
  };
  const arrow = arrows[direction] || arrows.down;

  return (
    <span
      className={`flashing-arrow flashing-arrow-${direction}`}
      style={{ fontSize: size }}
      aria-label={`Pil ${direction}`}
    >
      {arrow}
    </span>
  );
};

export default FlashingArrow;
