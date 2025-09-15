import { createContext, useContext, useEffect, useState } from 'react';
import bcrypt from 'bcryptjs';

const AuthContext = createContext(null);

export const AuthProvider = ({ children }) => {
  const [user, setUser] = useState(null);
  const [loading, setLoading] = useState(true);

  // Load user from localStorage when app starts
  useEffect(() => {
    const storedUser = localStorage.getItem('user');
    if (storedUser) {
      setUser(JSON.parse(storedUser));
    }
    setLoading(false);
  }, []);

  // Login function: accepts either email OR username as "identifier"
  const login = async (identifier, password) => {
    // Fetch all users from db.json
    const res = await fetch('http://localhost:5132/api/users');
    const users = await res.json();

    // Find user by email OR username
    const foundUser = users.find((u) => u.email === identifier || u.username === identifier);

    if (!foundUser) {
      throw new Error('Kunde inte hitta användaren');
    }

    // Compare given password with stored hash
    const isPasswordValid = await bcrypt.compare(password, foundUser.passwordHash);

    if (!isPasswordValid) {
      throw new Error('Felaktigt lösenord');
    }

    // Build safe user object (no password stored in state/localStorage)
    const safeUser = {
      id: foundUser.id,
      username: foundUser.username,
      email: foundUser.email,
      avatar: foundUser.avatarId, // Backend returnerar avatarId, inte avatar
      level: foundUser.level,
    };

    // Save in state and localStorage
    setUser(safeUser);
    localStorage.setItem('user', JSON.stringify(safeUser));
    localStorage.removeItem('lastResult'); // Remove guest results on login
  };

  // Logout function
  const logout = () => {
    setUser(null);
    localStorage.removeItem('user');
  };

  // Update user fields in context and localStorage
  const updateUser = (updatedFields) => {
    // Merge updated fields with current user
    const newUser = { ...user, ...updatedFields };
    setUser(newUser);
    localStorage.setItem('user', JSON.stringify(newUser));
  };

  return (
    <AuthContext.Provider value={{ user, login, logout, loading, updateUser }}>
      {children}
    </AuthContext.Provider>
  );
};

// Custom hook to easily access auth context
export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) throw new Error('useAuth must be used within an AuthProvider');
  return context;
};
