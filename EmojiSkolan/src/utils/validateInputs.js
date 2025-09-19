export function validateInputs(form, mode = 'register') {
  // Store error messages for each field
  const errors = {};
  // Store validity status for each field
  const valid = {};

  // Validate username: length and allowed characters
  const username = String(form.username ?? '').trim();
  if ('username' in form) {
    if (username.length < 3) {
      errors.username = 'Minst 3 tecken';
    } else if (username.length > 20) {
      errors.username = 'Högst 20 tecken';
    } else if (!/^[a-zA-Z0-9._-]+$/.test(username)) {
      errors.username = "Endast bokstäver, siffror, '.', '_' och '-'";
    }
    valid.username = !errors.username;
  }

  // Validate email: must match email pattern
  const email = String(form.email ?? '').trim();
  if ('email' in form) {
    if (!/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/.test(email)) {
      errors.email = 'Ogiltig e-postadress';
    }
    valid.email = !errors.email;
  }

  // Validate password: at least 8 chars, contains letter and number
  const password = String(form.password ?? '');
  if ('password' in form) {
    if (mode === 'register' || password.length > 0) {
      if (password.length < 8 || !/[A-Za-z]/.test(password) || !/[0-9]/.test(password)) {
        errors.password = 'Minst 8 tecken, bokstav & siffra';
      }
      valid.password = !errors.password;
    } else {
      valid.password = true;
    }
  }

  // Validate confirmPassword: must match password
  if ('confirmPassword' in form) {
    if (mode === 'register' || password.length > 0 || form.confirmPassword.length > 0) {
      if (form.confirmPassword !== form.password) {
        errors.confirmPassword = 'Lösenorden matchar inte';
      }
      valid.confirmPassword = !errors.confirmPassword;
    } else {
      valid.confirmPassword = true;
    }
  }

  // Return errors and validity status for all fields
  return { errors, valid };
}
