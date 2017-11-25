using UnityEngine;

[System.Serializable]
public class FlyingEnemy : IEnemy
{
    int health;
    int attackDmg;
    EnemyType enemyType;

    public FlyingEnemy()
    {
        health = 10;
        attackDmg = 5;
        enemyType = EnemyType.FLYING_ENEMY;
    }

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

    public int AttackDmg
    {
        get
        {
            return attackDmg;
        }

        set
        {
            attackDmg = value;
        }
    }

    public EnemyType EnemyType
    {
        get
        {
            return enemyType;
        }

        set
        {
            enemyType = value;
        }
    }

    public void Attact()
    {
        Debug.Log("Flying Enemy Attack Called");
    }

    public void Move()
    {
        Debug.Log("Flying Enemy Move Called");
    }

    public void TakeDamage()
    {
        Debug.Log("Flying Enemy Take Damage Called");
    }
}