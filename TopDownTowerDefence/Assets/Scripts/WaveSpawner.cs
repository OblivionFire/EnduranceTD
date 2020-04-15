using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {
    #region Veriables
    #region Public Veriables
    public Transform enemyPrefab;
    public float spawnInter = 5f;
    public Transform spawnPoint1;
    public Text WaveCountDownText;
        #endregion
    #region private veriables
    private int waveCount = 0;
    private float countdown = 2f;
    #endregion
    #endregion

    private void Awake()
    {
        spawnPoint1 = this.gameObject.transform;
    }
    private void Update()
    {
        countdown -= Time.deltaTime;

        WaveCountDownText.text = (Mathf.Floor(countdown)+1).ToString();

        if(countdown <= .05)
        {
            StartCoroutine(spawnWave());
            countdown = spawnInter;
        }
    }

    IEnumerator spawnWave()
    {
        waveCount++;
        //Eventually write this code to import all enemy types to be used into like temp veriables so that MonsterLog isnt being called every spawn
        for (int i = 0; i <= waveCount; i++)
        {
            spawnEnemy(1, 1, spawnPoint1);
            yield return new WaitForSeconds(0.5f);
        }
    }

    void spawnEnemy(int enemyType, int enemyLevel, Transform spawnLocation)
    {
        GameObject temp = getEnemy(enemyType, enemyLevel);
        Instantiate(temp, spawnLocation.position, spawnLocation.rotation);
    }

    private GameObject getEnemy(int enemyType, int EnemyLevel)
    {
        //Still need to unlcude math for enemy level
        return EnemyMasterLog.getEnemy(enemyType, EnemyLevel);
    }
}
