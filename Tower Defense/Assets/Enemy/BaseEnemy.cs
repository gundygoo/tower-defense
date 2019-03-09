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

    //Base imp of Init - Should be overridden in child class
    public void Init()
    {
        throw new System.NotImplementedException();
    }

    //Base imp of Move - Should be overridden in child class
    public void Move()
    {
        throw new System.NotImplementedException();
    }

    //Base imp of UpdateHealth - Should be overridden in child class
    public void UpdateHealth(int updateHealthAmount)
    {
        throw new System.NotImplementedException();
    }
}
