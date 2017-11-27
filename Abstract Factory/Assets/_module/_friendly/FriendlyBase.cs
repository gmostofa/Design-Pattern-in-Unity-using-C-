using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FriendlyBase {

    int health;
    int attackPower;

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public int AttackPower
    {
        get
        {
            return attackPower;
        }

        set
        {
            attackPower = value;
        }
    }

    public abstract void Move();
    public abstract void Attack();
}
