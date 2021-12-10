using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : ActorAttack
{
    private float attackDistance;

    private void Start()
    {
        attackDistance = GetComponent<EnemyMoveDirection>().AttackDistance;
    }

    private void Update()
    {
        if (Vector3.Distance(PlayerIdentifier.Instance.transform.position, transform.position) <= attackDistance)
        {
            Attack();
        }
    }

    protected override void AttackCore()
    {
        PlayerIdentifier.Instance.playerHealth.ReceiveDamage(damageAmount);
    }
}
