using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {

        private static T s_Instance;

        public static T Instance => s_Instance;


        protected virtual void Awake()
        {
            if (s_Instance == null)
            {
                s_Instance = FindAnyObjectByType<T>();
                DontDestroyOnLoad(this);
            }

            else if (s_Instance != this)
                Destroy(gameObject);

        }

    }
}
