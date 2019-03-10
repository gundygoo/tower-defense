using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseTower : MonoBehaviour
{
    // The damage of the tower
    protected int damage;

    // The range of the tower
    protected int range;

    // The image for the tower
    protected Image towerImage;

    // The Idle Animation for the tower 
    public Animation towerIdle;

    // The Attacking Animation for the tower
    public Animation towerAttack;

    // The rate of fire of the tower
    protected int rateOfFire;

    // The attack function
    protected Attack attack;

    protected abstract void Init();

    // Start is called before the first frame update
    void Start()
    {
        attack = Attack.Basic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
