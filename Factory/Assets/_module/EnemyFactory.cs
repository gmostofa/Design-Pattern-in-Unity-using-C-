using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory
{
    public IEnemy GetEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.FLYING_ENEMY:
                return new FlyingEnemy();
            case EnemyType.SWIMING_ENEMY:
                return new SwimingEnemy();
            case EnemyType.WALKING_ENEMY:
                return new WalkingEnemy();
            default:
                return new FlyingEnemy();
        }
    }
}
