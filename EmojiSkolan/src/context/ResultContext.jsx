import { createContext, useContext, useState, useEffect } from 'react';
import { useAuth } from './AuthContext';

const ResultContext = createContext();

export const ResultProvider = ({ children }) => {
  const { user } = useAuth();

  const [rounds, setRounds] = useState(0);
  const [time, setTime] = useState(0);
  const [currentLevel, setCurrentLevel] = useState(1);
  const [bestResults, setBestResults] = useState({});

  // Reset state when no user is logged in
  useEffect(() => {
    if (!user) {
      setCurrentLevel(1);
      setRounds(0);
      setTime(0);
      setBestResults({});
    }
  }, [user]);

  // Fetch all best results for the logged-in user
  useEffect(() => {
    if (user) {
      fetch(`http://localhost:5132/api/users/${user.id}`)
        .then((res) => res.json())
        .then((userData) => {
          // Backend returnerar Records som en array, konvertera till objekt
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

  // Update best result - backend handles all comparison logic
  const updateBestResult = async (rounds, time, level, userId) => {
    console.log('level:', level, 'rounds:', rounds, 'time:', time, 'userId:', userId);
    await saveUserRecord(userId, level, rounds, time);
    // Refresh user data after saving to get updated records
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

  // Save user record to the database using approach 1: check first, then act
  const saveUserRecord = async (userId, level, rounds, time) => {
    console.log('level:', level, 'rounds:', rounds, 'time:', time, 'userId:', userId);
    try {
      // First, check if record already exists by fetching user data
      const userResponse = await fetch(`http://localhost:5132/api/users/${userId}`);
      if (!userResponse.ok) {
        throw new Error('Failed to fetch user data');
      }

      const userData = await userResponse.json();
      const existingRecord = userData.records?.find((record) => record.levelId === level);

      if (existingRecord) {
        // Record exists, use PUT to update it
        console.log('Existing record found, updating...');
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
        console.log('Record updated successfully:', result);
      } else {
        // No existing record, use POST to create new one
        console.log('No existing record found, creating new...');
        console.log('POST LevelId:', level, 'Rounds:', rounds, 'Time:', time, 'UserId:', userId);
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
        console.log('New record created successfully:', result);
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
