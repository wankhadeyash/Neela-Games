using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NeelaGames.AnimalRescue {

    public class SceneSwitchBT : MonoBehaviour
    {
        public int sceneIndexToLoad;

        public void OnButtonClicked()
        {
            GameManager.Instance.LoadLevel(sceneIndexToLoad);
        }

        public void ReloadScene() 
        {
            GameManager.Instance.RestartLevel();
        }
    }
}