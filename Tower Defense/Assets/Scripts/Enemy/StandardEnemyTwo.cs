using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemyTwo : BaseEnemy
{
    protected override void Init()
    {
        health = 200;
        speed = 3;
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
