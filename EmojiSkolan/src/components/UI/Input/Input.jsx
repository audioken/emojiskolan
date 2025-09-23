import './Input.css';

function Input({
  label,
  name,
  value,
  onChange,
  error,
  valid,
  readOnly,
  disabled,
  type = 'text',
  showPasswordToggle = false,
  onPasswordToggle,
}) {
  return (
    <div className="form-group">
      <label className="label-title" htmlFor={name}>
        {label}
      </label>
      <div className="input-wrapper">
        <input
          id={name}
          name={name}
          type={type}
          value={value}
          onChange={onChange}
          readOnly={readOnly}
          disabled={disabled}
          autoComplete="off"
          className={`${value ? (error ? 'invalid' : valid ? 'valid' : '') : ''} ${showPasswordToggle ? 'with-toggle' : ''}`}
          required
        />
        {showPasswordToggle && (
          <button
            type="button"
            onClick={onPasswordToggle}
            className="password-toggle-inside"
            tabIndex={-1}
          >
            {type === 'password' ? (
              <i className="fa-solid fa-eye" aria-label="Hide password" title="Hide password"></i>
            ) : (
              <i className="fa-solid fa-eye-slash" aria-label="Show password" title="Show password"></i>
            )}
          </button>
        )}
        {value && error ? <div className="error">{error}</div> : null}
      </div>
    </div>
  );
}

export default Input;
