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
    const res = await fetch('http://localhost:5132/api/users');
    const users = await res.json();

    const foundUser = users.find((u) => u.email === identifier || u.username === identifier);

    if (!foundUser) {
      throw new Error('Kunde inte hitta användaren');
    }

    const isPasswordValid = await bcrypt.compare(password, foundUser.passwordHash);

    if (!isPasswordValid) {
      throw new Error('Felaktigt lösenord');
    }

    const safeUser = {
      id: foundUser.id,
      username: foundUser.username,
      email: foundUser.email,
      avatar: foundUser.avatarId,
      level: foundUser.level,
    };

    setUser(safeUser);
    localStorage.setItem('user', JSON.stringify(safeUser));
    localStorage.removeItem('lastResult'); 
  };

  const logout = () => {
    setUser(null);
    localStorage.removeItem('user');
  };

  const updateUser = (updatedFields) => {
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

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) throw new Error('useAuth must be used within an AuthProvider');
  return context;
};
