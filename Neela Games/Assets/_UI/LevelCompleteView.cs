using NeelaGames.AnimalRescue;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteView : MonoBehaviour
{
    public GameObject container;

    private void OnEnable()
    {
        container.SetActive(false);
        GameManager.OnLevelCompleted += OnLevelCompleted;
    }

    private void OnLevelCompleted()
    {
        container.SetActive(true);
    }

    private void OnDisable()
    {
        GameManager.OnLevelCompleted -= OnLevelCompleted;

    }
    
}
