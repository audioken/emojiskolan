// Generate a random password of given length
// Includes lowercase, uppercase, numbers and special chars
function generateRandomPassword(length = 12) {
  if (length < 4) {
    throw new Error("Password length must be at least 4");
  }

  const lowercase = "abcdefghijklmnopqrstuvwxyz";
  const uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  const digits = "0123456789";
  const specials = "!@#$%^&*()-_=+[]{};:,.<>?";
  const allChars = lowercase + uppercase + digits + specials;

  // Ensure at least one of each category
  const passwordChars = [
    lowercase[Math.floor(Math.random() * lowercase.length)],
    uppercase[Math.floor(Math.random() * uppercase.length)],
    digits[Math.floor(Math.random() * digits.length)],
    specials[Math.floor(Math.random() * specials.length)],
  ];

  // Fill the rest randomly
  for (let i = passwordChars.length; i < length; i++) {
    const randomIndex = Math.floor(Math.random() * allChars.length);
    passwordChars.push(allChars[randomIndex]);
  }

  // Shuffle so guaranteed chars are not always first
  for (let i = passwordChars.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [passwordChars[i], passwordChars[j]] = [passwordChars[j], passwordChars[i]];
  }

  return passwordChars.join("");
}

export default generateRandomPassword;