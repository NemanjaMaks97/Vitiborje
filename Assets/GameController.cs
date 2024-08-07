using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<GameObject> Obstacles;

    public Transform SpawnerTop;
    public Transform SpawnerBottom;

    private Timer timer;
    private System.Random random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnObstacle();
        random = new System.Random();
        //timer = new Timer(2000);
        //timer.Elapsed += Timer_Elapsed;
        //timer.AutoReset = false;
        //timer.Enabled = true;
        //timer.Start();
        StartCoroutine(SpawnTimer());
    }

    private IEnumerator SpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(random.Next(1, 2));
            SpawnObstacle();
        }
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        int spawnIndex = random.Next(0, Obstacles.Count);
        var obj = GameObject.Instantiate(Obstacles[spawnIndex]);
        obj.SetActive(true);
        obj.transform.position = new Vector3 (SpawnerTop.position.x, (float)GetNextPosition(), -1);
    }

    private double GetNextPosition()
    {
        return random.NextDouble() * (SpawnerTop.position.y - SpawnerBottom.position.y) + SpawnerBottom.position.y;
    }

    private void OnApplicationQuit()
    {
        StopAllCoroutines();
    }
}
