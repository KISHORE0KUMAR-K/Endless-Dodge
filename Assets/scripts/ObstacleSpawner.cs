using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate;
    public float maxXpos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartSpawning();
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    void Spawn()
    {
        float randomX = Random.Range(-maxXpos,maxXpos);
        Vector2 spawnPos = new Vector2(randomX,transform.position.y);
        Instantiate(obstacle,spawnPos,Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn",1f,spawnRate);

    }
    public  void StopSpawning()
    {
       CancelInvoke("Spawn");

    }
}
