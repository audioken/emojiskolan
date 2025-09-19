import './Input.css';

function Input({ label, name, value, onChange, error, valid, readOnly, disabled, type = 'text' }) {
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
          className={`${value ? (error ? 'invalid' : valid ? 'valid' : '') : ''}`}
          required
          {...(typeof autoFocus !== 'undefined' ? { autoFocus } : {})}
        />
        {/* Show error only if field has value and error exists */}
        {value && error ? <div className="error">{error}</div> : null}
      </div>
    </div>
  );
}

export default Input;
