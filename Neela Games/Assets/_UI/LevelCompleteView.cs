using NeelaGames.AnimalRescue;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteView : MonoBehaviour
{
    // Reference to the GameObject that will be shown when the level is completed.
    public GameObject container;

    // Method called when the script instance is being enabled.
    private void OnEnable()
    {
        // Initially set the container to inactive.
        container.SetActive(false);
        // Subscribe to the OnLevelCompleted event from the GameManager.
        GameManager.OnLevelCompleted += OnLevelCompleted;
    }

    // Method called when the level is completed.
    private void OnLevelCompleted()
    {
        // Activate the container GameObject.
        container.SetActive(true);
    }

    // Method called when the script instance is being disabled.
    private void OnDisable()
    {
        // Unsubscribe from the OnLevelCompleted event to prevent memory leaks.
        GameManager.OnLevelCompleted -= OnLevelCompleted;
    }
}
