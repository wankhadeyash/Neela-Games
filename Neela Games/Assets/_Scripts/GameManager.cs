using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace NeelaGames.AnimalRescue
{
    // This class manages the overall game state, including level loading and completion.
    public class GameManager : Singleton<GameManager>
    {
        // Event that is triggered when a level is completed.
        public static UnityAction OnLevelCompleted;

        // Method to start the game by loading the first level.
        public void StartGame()
        {
            LoadLevel(1);
        }

        // Method to restart the current level.
        public void RestartLevel()
        {
            // Reload the active scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Method to load a level by its index.
        public void LoadLevel(int levelIndex)
        {
            // Load the scene with the specified index.
            SceneManager.LoadScene(levelIndex);
        }

        // Method to load a level by its name.
        public void LoadLevel(string levelName)
        {
            // Load the scene with the specified name.
            SceneManager.LoadScene(levelName);
        }

        // Method to handle level completion.
        public void LevelCompleted()
        {
            // Invoke the OnLevelCompleted event if there are any subscribers.
            OnLevelCompleted?.Invoke();
        }
    }
}
