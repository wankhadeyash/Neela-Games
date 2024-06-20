using System.Collections;
using System.Collections.Generic;
using TMPro; // Namespace for TextMeshPro
using UnityEngine;
using UnityEngine.UI; // Namespace for Unity UI elements

namespace NeelaGames.AnimalRescue
{
    // This class is responsible for displaying level data in the UI.
    public class LevelDataView : MonoBehaviour
    {
        // Reference to the TextMeshProUGUI component that displays the level difficulty.
        public TextMeshProUGUI difficultyText;

        // Method to set the data in the view from the provided LevelDataSO.
        public void SetData(LevelDataSO data)
        {
            // Set the text of the difficultyText to the string representation of the level difficulty.
            difficultyText.text = data.levelDifficulty.ToString();
        }
    }
}
