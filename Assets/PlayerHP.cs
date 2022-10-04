using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour, ITakeDamage
{
    public int maxHP = 3;
    public int currentHP;
    // public HealthBar healthBar;

    private void Start()
    {
        currentHP = maxHP;
        // healthBar.SetMaxHealth(maxHP);
    }

    public void TakeDamage()
    {
        currentHP--;
        // healthBar.SetHealth(currentHP);
        if (currentHP <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }

}
