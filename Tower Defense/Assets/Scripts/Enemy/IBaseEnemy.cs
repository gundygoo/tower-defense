using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBaseEnemy
{
    //Do the health update things
    void UpdateHealth(int updateHealthAmount);

    //Do the speed update things
    void UpdateSpeed(int updateSpeedAmount);
}
