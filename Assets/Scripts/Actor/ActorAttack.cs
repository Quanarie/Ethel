using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAttack : MonoBehaviour
{
    [SerializeField] protected float damageAmount;

    [SerializeField] private float rechargeTime;

    private float previousAttackTime;

    protected void Attack() 
    {
        if (Time.time - previousAttackTime < rechargeTime)
            return;

        AttackCore();

        previousAttackTime = Time.time;
    }

    protected virtual void AttackCore() { }
}