using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int []  waveSize;
    public GameObject [] Enemy;
    public float enInterval;
    public Transform spawnPoint;
    public float startTime;
    public Transform[] Waypoints;
    public int [] enCount;
    int waveCount = 0;
    public GameObject Button;
    // Start is called before the first frame update
    void StartSpawning()
    {
        InvokeRepeating("SpawnWave", startTime, enInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (enCount[waveCount] == waveSize[waveCount])
        {
            if (waveCount < 3)
            {
                CancelInvoke("SpawnWave");
                waveCount++;
                Button.SetActive(true);
            }
        }
    }
    void SpawnWave()
    {
        enCount[waveCount]++;
        GameObject enemy = Instantiate(Enemy[waveCount], spawnPoint.position, Quaternion.identity);
        enemy.GetComponent<MoveToCheckPoint>().Waypoints = Waypoints;
    }
}
