using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int maxHealth = 100;
    int currentHealth;

    [SerializeField] HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update() 
    {
        if(currentHealth >= maxHealth) 
        {
            currentHealth = maxHealth;
        }
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void GainHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }
}
