using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // Enumeration to define different levels of difficulty.
    public enum LevelDifficulty
    {
        Easy,    // Easy level difficulty
        Medium,  // Medium level difficulty
        Hard     // Hard level difficulty
    }

    // This attribute makes it possible to create instances of this ScriptableObject from the Unity editor menu.
    [CreateAssetMenu(menuName = "ScriptableObject/LevelData")]
    public class LevelDataSO : ScriptableObject
    {
        // The difficulty level of the current level.
        public LevelDifficulty levelDifficulty;

        // The index of the scene associated with this level.
        public int sceneIndex;
    }
}
