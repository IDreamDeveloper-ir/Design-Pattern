using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] Slider healthBar;

    private void Start()
    {
        health.healthUpdate += UpdateUI;
        UpdateUI();
    }

    private void UpdateUI()
    {
        healthBar.value = health.GetHealthPersant();
    }
}
