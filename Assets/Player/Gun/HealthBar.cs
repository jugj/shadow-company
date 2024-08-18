using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Player playerHealth; 

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            healthBar = GetComponent<Slider>();
            healthBar.maxValue = playerHealth.maxHealth;
            healthBar.value = playerHealth.maxHealth;
    }
    void Update()
    {
    }
    public void SetHealth(int health)
    {
        healthBar.value = health;
    }
}
