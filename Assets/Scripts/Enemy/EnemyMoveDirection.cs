using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDirection : IMoveDirection
{
    [SerializeField] private float chaseDistance;
    [SerializeField] private float attackDistance;

    private void Update()
    {
        Vector3 playerPos = PlayerIdentifier.Instance.transform.position;

        if (Vector3.Distance(playerPos, transform.position) <= attackDistance ||
            Vector3.Distance(playerPos, transform.position) > chaseDistance)
        {
            Vertical = 0f;
            Horizontal = 0f;
        }
        else if (Vector3.Distance(playerPos, transform.position) > attackDistance ||
                 Vector3.Distance(playerPos, transform.position) <= chaseDistance)
        {
            Horizontal = playerPos.x - transform.position.x;
            Vertical = playerPos.y - transform.position.y;
        }
    }
}
