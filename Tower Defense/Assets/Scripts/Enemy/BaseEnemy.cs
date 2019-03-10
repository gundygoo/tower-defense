using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseEnemy : MonoBehaviour,  IBaseEnemy
{
    //The health of the enemy
    protected int health;

    //The speed of the enemy
    protected int speed;

    //The image for the enemy
    protected Image enemyImage;

    //The sprite for the enemy in uninjured state
    public Sprite enemySpriteDefault;

    //The sprite for the enemy in injured state
    public Sprite enemySpriteInjured;

    //The sprite for the enemy when it is destroyed
    public Sprite enemySpriteDestroyed;

    //The path to follow
    private Node[] path;

    //
    private float timer;

    private int currentNodeIndex = 0;

    private Vector3 currentNodePosition;

    private Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        enemyImage = GetComponent<Image>();
        path = GameObject.FindGameObjectWithTag("path-manager").GetComponent<PathManager>().GetPath();
        previousPosition = gameObject.transform.position;
        SetUpNextNode();

        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Move the Enemy
    protected void Move()
    {
        timer += Time.deltaTime * speed;

        if (gameObject.transform.position != currentNodePosition)
        {
            gameObject.transform.position = Vector3.Lerp(previousPosition, currentNodePosition, timer);
        }
        else
        {
            if (currentNodeIndex < path.Length - 1)
            {
                previousPosition = path[currentNodeIndex].transform.position;
                currentNodeIndex++;
                SetUpNextNode();
            }
        }
    }

    //Init the Enemy
    protected abstract void Init();

    //Base imp of UpdateHealth - Should be overridden in child class
    public void UpdateHealth(int updateHealthAmount)
    {
        TakeDamage(updateHealthAmount);

        health += updateHealthAmount;
        if (health <= 0) StartEnemyDeath();
    }

    //Indicate to the child class that the enemy has taken damage or healed
    protected abstract void TakeDamage(int updateHealthAmount);

    //Base imp of UpdateSpeed - Should be overrid
    public void UpdateSpeed(int updateSpeedAmount)
    {
        speed += updateSpeedAmount;
    }

    //Start the process of destroying this enemy
    protected void StartEnemyDeath()
    {
        EnemyDied();
        Destroy(gameObject);
    }

    //Indicate to the child class that the enemy has died
    protected abstract void EnemyDied();

    private void SetUpNextNode()
    {
        timer = 0;
        currentNodePosition = path[currentNodeIndex].transform.position;
    }
}
