using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NeelaGames.AnimalRescue
{
    public class LevelDataView : MonoBehaviour
    {
        public TextMeshProUGUI difficutlyText;

        public void SetData(LevelDataSO data) 
        {
            difficutlyText.text = data.levelDiffculty.ToString();
        }
    }
}
