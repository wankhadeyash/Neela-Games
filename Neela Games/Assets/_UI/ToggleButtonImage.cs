using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NeelaGames.AnimalRescue
{
    // This class manages a toggle button that switches between two different sprites.
    [RequireComponent(typeof(Button))]
    public class ToggleButtonImage : MonoBehaviour
    {
        // Sprites to display when the button is in the ON and OFF states.
        public Sprite ONSprite;
        public Sprite OFFSprite;

        // Reference to the Image and Button components attached to the GameObject.
        Image image;
        Button button;

        // Flag to track the current state of the button (ON or OFF).
        bool isOn;

        // Called when the script instance is being loaded.
        private void Awake()
        {
            // Get the Image and Button components from the GameObject.
            image = GetComponent<Image>();
            button = GetComponent<Button>();
        }

        // Called when the script instance is being enabled.
        private void OnEnable()
        {
            // Initialize the button to the ON state.
            isOn = true;
            image.sprite = ONSprite;

            // Add a listener to detect when the button is clicked.
            button.onClick.AddListener(OnButtonClicked);
        }

        // Called when the script instance is being disabled.
        private void OnDisable()
        {
            // Remove all listeners to prevent memory leaks.
            button.onClick.RemoveAllListeners();
        }

        // Method called when the button is clicked.
        void OnButtonClicked()
        {
            // Toggle the state of the button.
            isOn = !isOn;

            // Update the button's image based on the current state.
            image.sprite = isOn ? ONSprite : OFFSprite;
        }
    }
}
