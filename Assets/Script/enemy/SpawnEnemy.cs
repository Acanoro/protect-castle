using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int waveSize;
    public GameObject Enemy;
    public float enInterval;
    public Transform spawnPoint;
    public float startTime;
    public Transform[] Waypoints;
    int enCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWave", startTime, enInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (enCount == waveSize)
        {
            CancelInvoke("SpawnEnemy");
        }
    }
    void SpawnWave()
    {
        enCount++;
        GameObject enemy = GameObject.Instantiate(Enemy, spawnPoint.position, Quaternion.identity) as GameObject;
        enemy.GetComponent<MoveToCheckPoint>().Waypoints = Waypoints;
    }
}
