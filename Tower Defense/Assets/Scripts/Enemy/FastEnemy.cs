using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemy : BaseEnemy
{
    protected override void Init()
    {
        health = 50;
        speed = 5;
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
