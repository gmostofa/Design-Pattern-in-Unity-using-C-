using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<IEnemy> enemyList;
	EnemyFactory enemyFactory;

    void Awake()
    {
		enemyList = new List<IEnemy>();
		enemyFactory = new EnemyFactory();
    }
  
    void Start()
    {
		enemyList.Add(enemyFactory.GetEnemy(EnemyType.FLYING_ENEMY));
		enemyList.Add(enemyFactory.GetEnemy(EnemyType.SWIMING_ENEMY));
		enemyList.Add(enemyFactory.GetEnemy(EnemyType.WALKING_ENEMY));

		for (int i = 0; i < enemyList.Count; i++)
		{
			enemyList[i].Attact();
			enemyList[i].Move();
			enemyList[i].TakeDamage();
		}
    }

}
