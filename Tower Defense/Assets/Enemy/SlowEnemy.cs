using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowEnemy : BaseEnemy
{
    protected override void Init()
    {
        health = 500;
        speed = 25;
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
