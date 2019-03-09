using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBaseEnemy
{
    //Do the init things
    void Init();

    //Do the move things
    void Move();

    //Do the health update things
    void UpdateHealth(int updateHealthAmount);
}
