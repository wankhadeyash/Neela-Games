using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public class SoundBT : MonoBehaviour
    {
        public void OnButtonClicked() 
        {
            AudioManager.Instance.ToggleBackgroundAudio();
        }
    }
}
