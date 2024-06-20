using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // This class handles button clicks to toggle background audio.
    public class SoundBT : MonoBehaviour
    {
        // Method called when the associated button is clicked.
        public void OnButtonClicked()
        {
            // Toggle the background audio on or off using the AudioManager.
            AudioManager.Instance.ToggleBackgroundAudio();
        }
    }
}
