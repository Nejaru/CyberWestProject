using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerRightSide : MonoBehaviour {

	public GameObject Enemy;

	float randx;
	Vector2 whereToSpawn;
	public float spawnRate;
	float nextSpawn = 0.0f;
	public float  modRate;
    public int score;

	void Start () {

	}

	void Update () {
		/*if(Time.time > 2 % modRate && spawnRate >= .2){
			spawnRate-= .2f;

		}*/

		if (Time.time > nextSpawn) {

			nextSpawn = Time.time + spawnRate;
			randx = Random.Range (13f , 10f);
			whereToSpawn = new Vector2 (randx, transform.position.y);
			Instantiate (Enemy, whereToSpawn, Quaternion.identity); 

		}
	}
}
