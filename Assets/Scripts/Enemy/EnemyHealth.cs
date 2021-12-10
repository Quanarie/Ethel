using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : ActorHealth
{
    protected override void Death()
    {
        Destroy(gameObject);
    }
}
