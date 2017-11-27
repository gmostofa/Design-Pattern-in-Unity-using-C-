using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory  {

	public static FactoryBase GetFactory(NPCType npcType)
    {
        switch (npcType)
        {
            case NPCType.ENEMY:
                return new EnemyFactory();
            case NPCType.FRIEND:
                return new FriendlyFactory();
            default:
                return null;
        }
    }
}
