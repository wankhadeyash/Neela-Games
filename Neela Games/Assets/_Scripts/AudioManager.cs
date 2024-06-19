using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public class AudioManager : Singleton<AudioManager>
    {
       public  AudioSource backgroundAudio;

        public void ToggleBackgroundAudio() 
        {
           float volume = backgroundAudio.volume; //1.5,2.3 //int 1,2,3// string "Yash"
           if(volume == 1)
                backgroundAudio.volume = 0;
            else
                backgroundAudio.volume = 1;
        }
    }
}
