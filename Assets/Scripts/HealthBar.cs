using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Gradient healthBarGradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        healthBar.maxValue = health;
        healthBar.value = health;

        fill.color = healthBarGradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        healthBar.value = health;

        fill.color = healthBarGradient.Evaluate(healthBar.normalizedValue);
    }

}
