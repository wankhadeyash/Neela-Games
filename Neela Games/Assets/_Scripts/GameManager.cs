using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NeelaGames.AnimalRescue
{
    public class GameManager : Singleton<GameManager>
    {
        public void StartGame()
        {
            LoadLevel(1);
        }

        public void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void LoadLevel(int levelIndex)
        {
            SceneManager.LoadScene(levelIndex);
        }

        public void LoadLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}

