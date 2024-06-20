using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // This class manages the game's audio, specifically the background audio.
    public class AudioManager : Singleton<AudioManager>
    {
        // Reference to the AudioSource component that plays the background audio.
        public AudioSource backgroundAudio;

        // Method to toggle the background audio on and off.
        public void ToggleBackgroundAudio()
        {
            // Get the current volume of the background audio.
            float volume = backgroundAudio.volume;

            // If the volume is 1 (audio is playing), set it to 0 (mute).
            // Otherwise, set it to 1 (play audio).
            if (volume == 1)
                backgroundAudio.volume = 0;
            else
                backgroundAudio.volume = 1;
        }
    }
}
