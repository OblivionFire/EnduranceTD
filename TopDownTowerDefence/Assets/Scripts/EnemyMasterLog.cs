using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMasterLog : MonoBehaviour {

    public static GameObject[] enemies;
    public GameObject enemy1;
    public static EnemyMasterLog instance;

    #region Level Multiplier
    public float level1Speed = 1.5f;
    public float level1strength = 1.5f;
    public float level2Speed = 2.5f;
    public float level2strength = 2.5f;
    public float level3Speed = 4f;
    public float level3Strength = 4f;
    public float level4Speed = 5.5f;
    public float level4strength = 5.5f;
    public float level5Speed = 7f;
    public float level5strength = 7f;
    public int levelCount = 5;
    #endregion





    private void Awake()
    {
        if(instance == null)
        {
            instance = new EnemyMasterLog();
        }
        enemies = new GameObject[1];
        enemies[0] = enemy1;
        
    }

    public static GameObject getEnemy(int enemyNumber, int enemyLevel)
    {
        //Still need to implement code to include enemy level8
        if((enemyNumber-1 <= enemies.Length) && (enemyLevel <= instance.levelCount))
        {
            return enemies[enemyNumber - 1];
        }
        else
        {
            return null;
        }
    }


}
