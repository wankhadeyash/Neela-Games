using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeelaGames.AnimalRescue
{
    // This class handles navigation between different views in the game.
    public class ViewNavigation : MonoBehaviour
    {
        // Reference to the current view GameObject.
        public GameObject currentView;

        // Reference to the view GameObject to navigate to.
        public GameObject viewToNavigate;

        // Method to navigate from the current view to the specified view.
        public void NavigateToView()
        {
            // Activate the view to navigate to.
            viewToNavigate.SetActive(true);

            // Deactivate the current view.
            currentView.SetActive(false);
        }
    }
}
