using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemyOne : BaseEnemy
{
    protected override void Init()
    {
        health = 100;
        speed = 2;
    }

    protected override void TakeDamage(int updateHealthAmount)
    {
        //show damage anim
    }

    protected override void EnemyDied()
    {
        //show death anim
    }
}
