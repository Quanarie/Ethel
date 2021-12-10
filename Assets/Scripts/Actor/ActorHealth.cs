using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorHealth : MonoBehaviour
{
    [SerializeField] protected float maxHealth;

    protected float currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void ReceiveDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;

            Death();
        }
    }

    protected virtual void Death() { }
}
