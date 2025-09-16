// Import CSS styles for the field (so input and buttons look correct)

// A reusable input component
function Input({
  label, // Text displayed above the field (e.g. "Username")
  name, // Name of the field (used to identify input)
  value, // Current value in the input field
  onChange, // Function called when the user types in the field
  onClear, // Function called when the user clicks "X" to clear the field
  error, // Error message if something is invalid (shown below label)
  valid, // Boolean (true/false) if the field is valid
  readOnly, // If the field should be read-only
  disabled, // If the field should be completely disabled
  type = 'text', // Type of input (text, email, password, etc.), default is "text"
  hovered, // Boolean indicating if the mouse is over the field
  setHovered, // Function to update hovered state
}) {
  // Condition: show "clear button" (X) if the field is not readonly,
  // mouse is over the field and there is something written
  const showClear = !readOnly && hovered && value;

  return (
    <div
      className="form-group" // Wrapper around the whole field
      // Update hovered state when mouse enters or leaves the field
      onMouseEnter={() => setHovered?.(true)}
      onMouseLeave={() => setHovered?.(false)}
    >
      {/* Label above the field */}

      <label className="label-title" htmlFor={name}>
        {label}
      </label>
      {/* Show error message only if field has value and error exists */}
      {error && value && <div className="error">{error}</div>}

      {/* Wrapper for input + buttons */}
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
          style={{
            border: value
              ? error
                ? '2px solid #ff4136' // Red border if error and not empty
                : valid
                  ? '2px solid #2ecc40' // Green border if valid and not empty
                  : '1px solid #ccc' // Default border if not valid
              : '1px solid #ccc', // Default border if empty
            outline: 'none',
          }}
          required
          {...(typeof autoFocus !== 'undefined' ? { autoFocus } : {})}
        />

        {/* Clear button (X) only shown if showClear is true */}
        {showClear && (
          <button
            className="clear-button"
            onClick={onClear} // Calls the function that resets the field
            type="button"
            tabIndex={-1}
          >
            ✖
          </button>
        )}
      </div>
    </div>
  );
}

export default Input;
