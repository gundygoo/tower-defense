using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour,  IBaseEnemy
{
    //The health of the enemy
    protected int health;

    //The speed of the enemy
    protected int speed;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Move the Enemy
    protected abstract void Move();

    //Init the Enemy
    protected abstract void Init();

    //Base imp of UpdateHealth - Should be overridden in child class
    public void UpdateHealth(int updateHealthAmount)
    {
        throw new System.NotImplementedException();
    }

    //Base imp of UpdateSpeed - Should be overrid
    public void UpdateSpeed(int updateSpeedAmount)
    {
        speed += updateSpeedAmount;
    }
}
