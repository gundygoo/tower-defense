using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour
{
    // The damage of the tower
    protected int damage;

    // The range of the tower
    protected int range;

    // The rate of fire of the tower
    protected int rateOfFire;

    protected Attack attack;

    // Start is called before the first frame update
    void Start()
    {
        attack = Attack.Fire;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
