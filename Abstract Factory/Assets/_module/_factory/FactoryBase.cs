using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryBase  {

   public abstract EnemyBase GetEnemy(EnemyType enemyType);
   public abstract FriendlyBase GetFriendly(FriendType friendType);
}
