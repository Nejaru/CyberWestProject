using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    float randX, randY;
    Vector2 spawnLocation;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + (1 / spawnRate);
            do
            {
                randX = Random.Range(-6.1f, 6.1f);
                randY = Random.Range(-6.1f, 6.1f);
            } while (Mathf.Abs(randX) + Mathf.Abs(randY) >= 7.5f && Mathf.Abs(randX) >= 5.0f && Mathf.Abs(randY) >= 5.0f);
            spawnLocation = new Vector2(randX, randY);
            Instantiate(enemy, spawnLocation, Quaternion.identity);
        }
    }
}
