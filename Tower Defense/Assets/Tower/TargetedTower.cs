using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetedTower : BaseTower
{
    private SpriteRenderer mySpriteRenderer;

    protected IBaseEnemy target;

    protected override void Init()
    {
        damage = 100;
        range = 200;
        rateOfFire = 200;
    }

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select()
    {
        mySpriteRenderer.enabled = !mySpriteRenderer.enabled;
    }
}
