﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemyThree : BaseEnemy
{
    protected override void Init()
    {
        health = 300;
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
