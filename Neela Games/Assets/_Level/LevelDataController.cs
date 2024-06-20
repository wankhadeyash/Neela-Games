using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // This class is responsible for managing level data within the game.
    public class LevelDataController : MonoBehaviour
    {
        // A reference to the ScriptableObject that holds level data.
        public LevelDataSO model;

        // A reference to the view component that will display the level data.
        public LevelDataView view;

        // This method is called when the object becomes enabled and active.
        private void OnEnable()
        {
            // Set the view with the data from the model.
            view.SetData(model);
        }

        // This method is called when a level is selected by the player.
        public void OnLevelSelected()
        {
            // Use the GameManager instance to load the level specified by the scene index in the model.
            GameManager.Instance.LoadLevel(model.sceneIndex);
        }
    }
}
