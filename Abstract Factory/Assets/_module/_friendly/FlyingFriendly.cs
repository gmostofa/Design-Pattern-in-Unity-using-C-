using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingFriendly : FriendlyBase
{
    public FlyingFriendly()
    {
        Health = 100;
        AttackPower = 5;
    }

    public override void Attack()
    {
        Debug.Log("Flying Friendly Attack Called");
    }

    public override void Move()
    {
        Debug.Log("Flying Friendly Move Called");
    }
}
