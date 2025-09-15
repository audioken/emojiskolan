import { createContext, useContext, useEffect, useState } from "react";

const EmojiContext = createContext();

export const EmojiProvider = ({ children }) => {
  const [allEmojis, setAllEmojis] = useState([]);

  // Fetch emojis from the backend server
  useEffect(() => {
    fetch("http://localhost:5132/api/emojis")
      .then((res) => res.json())
      .then((data) => setAllEmojis(data));
  }, []);

  return (
    <EmojiContext.Provider value={{ allEmojis }}>
      {children}
    </EmojiContext.Provider>
  );
};

export const useEmoji = () => useContext(EmojiContext);
