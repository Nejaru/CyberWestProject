using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpawner : MonoBehaviour {

    public GameObject shoot;
    public GameObject shoot2;

    

   

    public void Fire()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Instantiate(shoot, new Vector3(playerPos.x, playerPos.y), Quaternion.identity);


    }

    public void FireLaser()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Instantiate(shoot2, new Vector3(playerPos.x, playerPos.y), Quaternion.identity);
        
    }
}
