using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // Generic Singleton class to ensure a single instance of a MonoBehaviour-derived class.
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // Static reference to the single instance of the class.
        private static T s_Instance;

        // Public property to access the instance of the class.
        public static T Instance => s_Instance;

        // Virtual method called when the script instance is being loaded.
        protected virtual void Awake()
        {
            // Check if an instance of the class already exists.
            if (s_Instance == null)
            {
                // If no instance exists, set this as the instance and make it persistent across scenes.
                s_Instance = FindAnyObjectByType<T>();
                DontDestroyOnLoad(this);
            }
            else if (s_Instance != this)
            {
                // If an instance already exists and it's not this, destroy the game object to enforce the singleton pattern.
                Destroy(gameObject);
            }
        }
    }
}
