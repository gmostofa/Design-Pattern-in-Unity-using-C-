using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingFriendly : FriendlyBase
{
    public WalkingFriendly()
    {
        Health = 100;
        AttackPower = 5;
    }

    public override void Attack()
    {
        Debug.Log("walking Friendly Attack Called");
    }

    public override void Move()
    {
        Debug.Log("walking Friendly move Called");
    }
}
