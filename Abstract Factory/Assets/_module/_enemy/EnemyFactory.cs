using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : FactoryBase
{
    public override EnemyBase GetEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.WALKING:
                return new WalkingEnemy();
               
            case EnemyType.FLYING:
                return new FlyingEnemy();
                
            default:
                return null;
                
        }
    }

    public override FriendlyBase GetFriendly(FriendType friendType)
    {
        return null;
    }
}
