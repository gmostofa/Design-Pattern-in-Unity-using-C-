using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyFactory : FactoryBase
{
    public override EnemyBase GetEnemy(EnemyType enemyType)
    {
        return null;
    }

    public override FriendlyBase GetFriendly(FriendType friendType)
    {
        switch (friendType)
        {
            case FriendType.WALKING:
                return new WalkingFriendly();
            case FriendType.FLYING:
                return new FlyingFriendly();
            default:
                return null;
        }
    }
}
