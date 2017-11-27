using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : EnemyBase {
    public FlyingEnemy()
    {
        Health = 100;
        AttackPower = 5;
    }

    public override void Attack()
    {
        Debug.Log("Flying Enemy Attack Called");
    }

    public override void Move()
    {
        Debug.Log("Flying Enemy Move Called");
    }
}
