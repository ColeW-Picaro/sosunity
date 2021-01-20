using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int maxHealth = 100; //sets a characters max hp
    public int currentHealth; //changes characters health

    public HealthBar healthBar; //connects healthbar script to character

    void Start()
    {
        currentHealth = maxHealth; //sets currenthealth to maxhealth
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //pressing space makes character take 20 damage
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage; //currenthealth minus how much damage he takes

        healthBar.SetHealth(currentHealth); //changes the slider to currenthealth
    }
}
