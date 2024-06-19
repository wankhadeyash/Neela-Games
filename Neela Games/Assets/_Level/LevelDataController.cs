using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public class LevelDataController : MonoBehaviour
    {
        public LevelDataSO model;

        public LevelDataView view;

        private void OnEnable()
        {
            view.SetData(model);
        }

        public void OnLevelSelected() 
        {
            GameManager.Instance.LoadLevel(model.sceneIndex);
        }
    }
}
