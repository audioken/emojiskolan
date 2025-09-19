import { createContext, useContext, useState, useEffect } from 'react';
import { useAuth } from './AuthContext';

const ResultContext = createContext();

export const ResultProvider = ({ children }) => {
  const { user } = useAuth();

  const [rounds, setRounds] = useState(0);
  const [time, setTime] = useState(0);
  const [currentLevel, setCurrentLevel] = useState(1);
  const [bestResults, setBestResults] = useState({});

  useEffect(() => {
    if (!user) {
      setCurrentLevel(1);
      setRounds(0);
      setTime(0);
      setBestResults({});
    }
  }, [user]);

  useEffect(() => {
    if (user) {
      fetch(`http://localhost:5132/api/users/${user.id}`)
        .then((res) => res.json())
        .then((userData) => {
          if (userData.records && Array.isArray(userData.records)) {
            const recordsObject = {};
            userData.records.forEach((record) => {
              recordsObject[record.levelId] = {
                rounds: record.rounds,
                time: record.time,
              };
            });
            setBestResults(recordsObject);
          }
        })
        .catch((error) => {
          console.error('Failed to fetch user records:', error);
        });
    }
  }, [user]);

  const updateBestResult = async (rounds, time, level, userId) => {
    await saveUserRecord(userId, level, rounds, time);

    if (user) {
      fetch(`http://localhost:5132/api/users/${user.id}`)
        .then((res) => res.json())
        .then((userData) => {
          if (userData.records && Array.isArray(userData.records)) {
            const recordsObject = {};
            userData.records.forEach((record) => {
              recordsObject[record.levelId] = {
                rounds: record.rounds,
                time: record.time,
              };
            });
            setBestResults(recordsObject);
          }
        })
        .catch((error) => {
          console.error('Failed to refresh user records:', error);
        });
    }
  };

  const saveUserRecord = async (userId, level, rounds, time) => {
    try {
      const userResponse = await fetch(`http://localhost:5132/api/users/${userId}`);
      if (!userResponse.ok) {
        throw new Error('Failed to fetch user data');
      }

      const userData = await userResponse.json();
      const existingRecord = userData.records?.find((record) => record.levelId === level);

      if (existingRecord) {
        const response = await fetch(`http://localhost:5132/api/users/${userId}/records/${level}`, {
          method: 'PUT',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify({
            LevelId: level,
            Rounds: rounds,
            Time: time,
          }),
        });

        if (!response.ok) {
          throw new Error(`Failed to update record: ${response.status}`);
        }

        const result = await response.json();
      } else {
        const response = await fetch(`http://localhost:5132/api/users/${userId}/records`, {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify({
            LevelId: level,
            Rounds: rounds,
            Time: time,
          }),
        });

        if (!response.ok) {
          throw new Error(`Failed to create record: ${response.status}`);
        }

        const result = await response.json();
      }
    } catch (error) {
      console.error('Error saving record:', error);
    }
  };

  return (
    <ResultContext.Provider
      value={{
        rounds,
        setRounds,
        time,
        setTime,
        currentLevel,
        setCurrentLevel,
        bestResults,
        updateBestResult,
      }}
    >
      {children}
    </ResultContext.Provider>
  );
};

export const useResults = () => {
  return useContext(ResultContext);
};
