using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NeelaGames.AnimalRescue
{
    [RequireComponent(typeof(Button))]
    public class ToggleButtonImage : MonoBehaviour
    {
        public Sprite ONSprite;
        public Sprite OFFSprite;

        Image image;
        Button button;
        bool isOn;

        private void Awake()
        {
            image = GetComponent<Image>(); 
            button = GetComponent<Button>();    
        }

        private void OnEnable()
        {
            isOn = true;
            image.sprite = ONSprite;
            button.onClick.AddListener(OnButtonClicked);
        }
        private void OnDisable()
        {
            button.onClick.RemoveAllListeners();
        }

        void OnButtonClicked() 
        {
            isOn = isOn ? false : true;
            image.sprite = isOn? ONSprite : OFFSprite;

        }
        
    }
}
