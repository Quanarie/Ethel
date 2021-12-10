using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : ActorHealth
{
    public void Heal(float toHeal)
    {
        currentHealth += toHeal;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    protected override void Death()
    {
        base.Death();
    }
}
