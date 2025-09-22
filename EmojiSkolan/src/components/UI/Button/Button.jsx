import { Link } from 'react-router-dom';
import './Button.css';

function Button({
  label,
  type = 'button',
  onClick,
  className = '',
  path,
  disabled = false,
  ariaLabel,
  title,
}) {
  if (path) {
    return (
      <Link
        to={disabled ? '#' : path}
        className={`${className}${disabled ? ' button-disabled' : ''}`}
        aria-label={ariaLabel}
        title={title}
        onClick={disabled ? (e) => e.preventDefault() : onClick}
      >
        {label}
      </Link>
    );
  }

  return (
    <button
      type={type}
      onClick={onClick}
      className={`${className}${disabled ? ' button-disabled' : ''}`}
      disabled={disabled}
      aria-label={ariaLabel}
      title={title}
    >
      {label}
    </button>
  );
}

export default Button;
