using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    
    private float originalScale; // initial health bar size

    public EnemyChar enChar;

    public float maxHealth; // maximum enemy health
    public float currentHealth; // remaining health

    void Start()
    {
        maxHealth = enChar.Health;
        currentHealth = enChar.Health;
        originalScale = gameObject.transform.localScale.y;
    }

    void Update()
    {
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.y = currentHealth / maxHealth * originalScale;
        gameObject.transform.localScale = tmpScale;
    }
}
