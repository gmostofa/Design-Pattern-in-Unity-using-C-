using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    FactoryBase enemyFactory;
    FactoryBase friendlyFactory;
    EnemyBase flyingEnemy;
    EnemyBase walkingEnemy;
    FriendlyBase flyingFriend;
    FriendlyBase walkingFriend;


    private void Awake()
    {
        enemyFactory = NPCFactory.GetFactory(NPCType.ENEMY);
        friendlyFactory = NPCFactory.GetFactory(NPCType.FRIEND);

        flyingEnemy = enemyFactory.GetEnemy(EnemyType.FLYING);
        walkingEnemy = enemyFactory.GetEnemy(EnemyType.WALKING);

        flyingFriend = friendlyFactory.GetFriendly(FriendType.FLYING);
        walkingFriend = friendlyFactory.GetFriendly(FriendType.WALKING);
    }

    void Start () {
        flyingEnemy.Attack();
        flyingEnemy.Move();

        walkingEnemy.Move();
        walkingEnemy.Attack();

        flyingFriend.Attack();
        flyingFriend.Move();

        walkingFriend.Attack();
        walkingFriend.Move();
	}
	
	
}
