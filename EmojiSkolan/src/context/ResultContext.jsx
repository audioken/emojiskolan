import { createContext, useContext, useState, useEffect } from 'react';
import { useAuth } from './AuthContext';

const ResultContext = createContext();

export const ResultProvider = ({ children }) => {
  const { user } = useAuth();

  const [rounds, setRounds] = useState(0);
  const [time, setTime] = useState(0);
  const [currentLevel, setCurrentLevel] = useState(1);
  const [bestResults, setBestResults] = useState({});
  const [globalBestResults, setGlobalBestResults] = useState({});

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

  // Fetch global highscores
  useEffect(() => {
    const fetchGlobalHighscores = async () => {
      try {
        const response = await fetch('http://localhost:5132/api/users');
        const allUsers = await response.json();

        const globalResults = {};

        // För varje nivå (1-10), hitta bästa resultatet
        for (let level = 1; level <= 10; level++) {
          let bestRecord = null;
          let bestUser = null;

          allUsers.forEach((user) => {
            if (user.records && Array.isArray(user.records)) {
              const levelRecord = user.records.find((record) => record.levelId === level);
              if (levelRecord) {
                // Jämför om detta är bättre (färre rundor, eller samma rundor men snabbare tid)
                if (
                  !bestRecord ||
                  levelRecord.rounds < bestRecord.rounds ||
                  (levelRecord.rounds === bestRecord.rounds && levelRecord.time < bestRecord.time)
                ) {
                  bestRecord = levelRecord;
                  bestUser = user.username;
                }
              }
            }
          });

          if (bestRecord) {
            globalResults[level] = {
              rounds: bestRecord.rounds,
              time: bestRecord.time,
              username: bestUser,
            };
          }
        }

        setGlobalBestResults(globalResults);
      } catch (error) {
        console.error('Failed to fetch global highscores:', error);
      }
    };

    fetchGlobalHighscores();
  }, []);

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

      // Uppdatera även global highscore
      refreshGlobalHighscores();
    }
  };

  const refreshGlobalHighscores = async () => {
    try {
      const response = await fetch('http://localhost:5132/api/users');
      const allUsers = await response.json();

      const globalResults = {};

      for (let level = 1; level <= 10; level++) {
        let bestRecord = null;
        let bestUser = null;

        allUsers.forEach((user) => {
          if (user.records && Array.isArray(user.records)) {
            const levelRecord = user.records.find((record) => record.levelId === level);
            if (levelRecord) {
              if (
                !bestRecord ||
                levelRecord.rounds < bestRecord.rounds ||
                (levelRecord.rounds === bestRecord.rounds && levelRecord.time < bestRecord.time)
              ) {
                bestRecord = levelRecord;
                bestUser = user.username;
              }
            }
          }
        });

        if (bestRecord) {
          globalResults[level] = {
            rounds: bestRecord.rounds,
            time: bestRecord.time,
            username: bestUser,
          };
        }
      }

      setGlobalBestResults(globalResults);
    } catch (error) {
      console.error('Failed to refresh global highscores:', error);
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
        globalBestResults,
        updateBestResult,
        refreshGlobalHighscores,
      }}
    >
      {children}
    </ResultContext.Provider>
  );
};

export const useResults = () => {
  return useContext(ResultContext);
};
