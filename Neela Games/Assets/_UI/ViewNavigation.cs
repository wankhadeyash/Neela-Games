using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    public class ViewNavigation : MonoBehaviour
    {
        public GameObject currentView;
        public GameObject viewToNavigate;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void NavigateToView() 
        {
            viewToNavigate.gameObject.SetActive(true);
            currentView.gameObject.SetActive(false);
        }
    }
}
