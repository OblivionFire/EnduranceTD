using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {
    #region Veriables
    #region Public Veriables
    public Transform enemyPrefab;
        public float spawnInter = 5f;
        #endregion
    #region private veriables
        private float waveCount = 1f;
        private float countdown = 2f;
        #endregion
    #endregion
    private void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0)
        {
            spawnWave();
            countdown = spawnInter;
        }
    }

    void spawnWave()
    {
        for (int i = 0; i < waveCount; i++)
        {
            
        }

        waveCount++;
    }

    void spwanEnemy(int enemyType, int enemyLevel, Transform spawnLocation)
    {

        Instantiate()
    }

    void getEnemy(int enemyType, int EnemyLevel)
    {
        
    }
}
