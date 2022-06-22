using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 100; // maximum enemy health
    public float currentHealth = 100; // remaining health
    private float originalScale; // initial health bar size

    void Start()
    {
        originalScale = gameObject.transform.localScale.y;
    }

    void Update()
    {
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.y = currentHealth / maxHealth * originalScale;
        gameObject.transform.localScale = tmpScale;
    }
}
