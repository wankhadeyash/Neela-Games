using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public enum LevelDifficulty
    {
        Easy,
        Medium,
        Hard
    }

    [CreateAssetMenu(menuName = "ScriptableObject/LevelData")]
    public class LevelDataSO : ScriptableObject
    {
        public LevelDifficulty levelDiffculty;
        public int sceneIndex;
    }
}
