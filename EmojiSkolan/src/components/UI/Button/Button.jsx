import { Link } from "react-router-dom";
import "./Button.css";

// function Button({ label, type = "button", onClick, className = "", path, disabled = false }) {
//   // Gör så man kan ta emot true false för disabled också

//   if (path) {
//     return (
//       <Link to={path} className={className} onClick={onClick}>
//         {label}
//       </Link>
//     );
//   }

//   return (
//     <button type={type} onClick={onClick} className={className}>
//       {label}
//     </button>
//   );
// }

// export default Button;

function Button({
  label,
  type = "button",
  onClick,
  className = "",
  path,
  disabled = false,
}) {
  if (path) {
    return (
      <Link
        to={disabled ? "#" : path}
        className={`${className}${disabled ? " button-disabled" : ""}`}
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
      className={`${className}${disabled ? " button-disabled" : ""}`}
      disabled={disabled}
    >
      {label}
    </button>
  );
}

export default Button;
