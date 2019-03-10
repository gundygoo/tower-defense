using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Difficulty difficultySetting = Difficulty.Normal;

    private float timer;

    public GameObject[] enemies;

    private const int SPAWN = 1;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > .5)
        {
            timer = 0;

            int determineIfSpawn = Random.Range(1, ((int)difficultySetting) + 1);
            if (determineIfSpawn == SPAWN)
            {
                int spawnEnemyNumber = Random.Range(1, enemies.Length);
                Instantiate(enemies[spawnEnemyNumber], gameObject.transform.position, gameObject.transform.rotation);
            }
        }
    }
}
