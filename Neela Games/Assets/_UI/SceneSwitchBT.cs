using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NeelaGames.AnimalRescue {

    public class SceneSwitchBT : MonoBehaviour
    {
        public int sceneIndexToLoad;
        public bool loadNextScene;

        public void OnButtonClicked()
        {
            if (loadNextScene)
            {
                if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
                {
                    GameManager.Instance.LoadLevel(0);
                    return;
                }
                GameManager.Instance.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
                return;
            }
            GameManager.Instance.LoadLevel(sceneIndexToLoad);
        }

        public void ReloadScene() 
        {
            GameManager.Instance.RestartLevel();
        }
    }
}