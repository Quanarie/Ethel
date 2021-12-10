using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : ActorAttack
{
    [SerializeField] private float attackDistance;

    private void Start()
    {
        GetComponent<PlayerInput>().OnInteractButtonPressed += Attack;
    }

    protected override void AttackCore()
    {
        Transform enemy = FindClosestEnemyInRange(attackDistance);

        if (enemy != null)
            enemy.GetComponent<EnemyHealth>().ReceiveDamage(damageAmount);
    }

    public Transform FindClosestEnemyInRange(float range)
    {
        Vector3 playerPos = PlayerIdentifier.Instance.transform.position;
        Collider2D[] objects = Physics2D.OverlapCircleAll(new Vector2(playerPos.x, playerPos.y), range);

        int enemiesQuantity = 0;
        foreach (Collider2D item in objects)
        {
            if (item.TryGetComponent(out EnemyHealth _))
                enemiesQuantity++;
        }

        Collider2D[] enemies = new Collider2D[enemiesQuantity];
        int enemyCounter = 0;
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].TryGetComponent(out EnemyHealth _))
            {
                enemies[enemyCounter] = objects[i];
                enemyCounter++;
            }
        }

        if (enemies.Length == 0)
            return null;

        int closestEnemy = 0;
        for (int i = 0; i < enemies.Length; i++)
        {
            if (Vector3.Distance(playerPos, enemies[i].transform.position) < Vector3.Distance(playerPos, enemies[closestEnemy].transform.position))
            {
                closestEnemy = i;
            }
        }

        return enemies[closestEnemy].transform;
    }
}
