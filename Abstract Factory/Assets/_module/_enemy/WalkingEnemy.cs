using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : EnemyBase {
    public WalkingEnemy()
    {
        AttackPower = 5;
        Health = 100;
    }

    public override void Attack()
    {
        Debug.Log("Walking Enemy Attack Called");
    }

    public override void Move()
    {
        Debug.Log("Walking Enemy Move Called");
    }
}
