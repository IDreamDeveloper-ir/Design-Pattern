using System;
using System.Collections;
using UnityEngine;


public class Health : MonoBehaviour {
    [SerializeField] float fullHealth = 100f;
    [SerializeField] float drainPerSecond = 2f;

    public event Action healthUpdate;
    
    float currentHealth = 0;

    private void Awake() {
        ResetHealth();
        StartCoroutine(HealthDrain());
    }
    
    private void OnEnable() {
        GetComponent<Level>().onLevelUpAction += ResetHealth;
    }

    private void OnDisable() {
        GetComponent<Level>().onLevelUpAction -= ResetHealth;
    }

    public float GetHealth()
    {
        return currentHealth;
    }

    public float GetHealthPersant()
    {
        return currentHealth / fullHealth;
    }

    void ResetHealth()
    {
        currentHealth = fullHealth;
        healthUpdate?.Invoke();
    }

    private IEnumerator HealthDrain()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            healthUpdate?.Invoke();
            yield return new WaitForSeconds(1);
        }
    }
}