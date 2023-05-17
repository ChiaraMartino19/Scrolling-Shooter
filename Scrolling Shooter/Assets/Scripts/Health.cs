using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth; 
    private int currentHealth;
    public Slider barraHealth;

    private void Start()
    {
        currentHealth = maxHealth; 
        barraHealth.maxValue = maxHealth; 
        barraHealth.value = maxHealth; 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        barraHealth.value = currentHealth; 

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
