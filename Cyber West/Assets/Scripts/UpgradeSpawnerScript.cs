using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawnerScript : MonoBehaviour
{
    public GameObject upgrade;
    float randX, randY;
    Vector2 spawnLocation;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
	
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + (spawnRate);
            do
            {
                randX = Random.Range(-5.0f, 5.0f);
                randY = Random.Range(-4.5f, 5.0f);
            } while (Mathf.Abs(randX) + Mathf.Abs(randY) >= 5.0f || randY <= -4.5f);
            spawnLocation = new Vector2(randX, randY);
            Instantiate(upgrade, spawnLocation, Quaternion.identity);
        }
	}
}
