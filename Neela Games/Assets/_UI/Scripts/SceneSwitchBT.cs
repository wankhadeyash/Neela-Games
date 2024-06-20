using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NeelaGames.AnimalRescue
{
    // This class handles scene switching and reloading functionality based on button clicks.
    public class SceneSwitchBT : MonoBehaviour
    {
        // Index of the scene to load directly (if loadNextScene is false).
        public int sceneIndexToLoad;

        // Flag to determine whether to load the next scene in the build order.
        public bool loadNextScene;

        // Method called when the associated button is clicked.
        public void OnButtonClicked()
        {
            if (loadNextScene)
            {
                // If loadNextScene is true, load the next scene in the build order.
                if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
                {
                    // If currently at the last scene, loop back to the first scene.
                    GameManager.Instance.LoadLevel(0);
                    return;
                }
                // Load the next scene after the current scene.
                GameManager.Instance.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
                return;
            }
            // Load the scene specified by sceneIndexToLoad.
            GameManager.Instance.LoadLevel(sceneIndexToLoad);
        }

        // Method to reload the current scene.
        public void ReloadScene()
        {
            // Call GameManager's RestartLevel method to reload the current scene.
            GameManager.Instance.RestartLevel();
        }
    }
}
