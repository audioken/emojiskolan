// This function validates user input for forms like Register and Login.
// It returns two objects:
// - errors: contains error messages for invalid fields (in Swedish)
// - valid: contains booleans indicating if each field is valid
export function validateInputs(form, mode = "register") {
  const errors = {};
  const valid = {};

  // --- Username validation ---
  const username = String(form.username ?? "").trim(); // Remove leading/trailing spaces
  if ("username" in form) {
    if (username.length === 0) {
      errors.username = "Användarnamn krävs";
    } else if (username.length < 3) {
      errors.username = "Måste vara minst 3 tecken";
    } else if (username.length > 20) {
      errors.username = "Måste vara högst 20 tecken";
    } else if (!/^[a-zA-Z0-9._-]+$/.test(username)) {
      errors.username = "Endast bokstäver, siffror, '.', '_' och '-'";
    }
    valid.username = !errors.username;
  }

  // --- Email validation ---
  const email = String(form.email ?? "").trim();
  if ("email" in form) {
    if (email.length === 0) {
      errors.email = "E-post krävs";
    } else if (
      !/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/.test(email)
    ) {
      errors.email = "Ogiltig e-postadress";
    }
    valid.email = !errors.email;
  }

  // --- Password validation ---
  const password = String(form.password ?? "");
  if ("password" in form) {
    if (mode === "register" || password.length > 0) {
      if (password.length === 0) {
        errors.password = "Lösenord krävs";
      } else if (password.length < 8) {
        errors.password = "Måste vara minst 8 tecken";
      } else if (!/[A-Za-z]/.test(password) || !/[0-9]/.test(password)) {
        errors.password = "Måste innehålla minst en bokstav och en siffra";
      }
      valid.password = !errors.password;
    } else {
      // Password is optional in profile mode
      valid.password = true;
    }
  }

  // --- Confirm password validation ---
  if ("confirmPassword" in form) {
    if (mode === "register" || password.length > 0 || form.confirmPassword.length > 0) {
      if (form.confirmPassword !== form.password) {
        errors.confirmPassword = "Lösenorden matchar inte";
      } else if (!form.confirmPassword) {
        errors.confirmPassword = "Vänligen bekräfta ditt lösenord";
      }
      valid.confirmPassword = !errors.confirmPassword;
    } else {
      // Confirm password is optional in profile mode
      valid.confirmPassword = true;
    }
  }

  // Return both error messages and valid flags
  return { errors, valid };
}
