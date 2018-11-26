using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemySpawner : MonoBehaviour {


	public GameObject Enemy;

	float randx;
	float randx2;
	Vector2 whereToSpawn;
	Vector2 whereToSpawn2;
    public float spawnRate;
    float nextSpawn = 0.0f;
    float nextSpawn2 = 0.0f;
    public float  modRate;
    public int score = 0;
    public Text scoreText;

    void Start () {
		
	}
	
	void Update () {
		/*if(Time.time > 2 % modRate && spawnRate >= .2){
			spawnRate-= .2f;

		}*/

		if (Time.time > nextSpawn)
        {
			nextSpawn = Time.time + spawnRate;
			randx = Random.Range (-13f , -10f);
			whereToSpawn = new Vector2 (randx, transform.position.y);
			Instantiate (Enemy, whereToSpawn, Quaternion.identity);
		}
        if (Time.time > nextSpawn2)
        {
            nextSpawn2 = Time.time + spawnRate;
            randx2 = Random.Range(13f, 10f);
            whereToSpawn2 = new Vector2(randx2, transform.position.y);
            Instantiate(Enemy, whereToSpawn2, Quaternion.identity);
        }
    }
}
