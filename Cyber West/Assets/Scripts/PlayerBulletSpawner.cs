using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpawner : MonoBehaviour {

    public GameObject shoot;
    public GameObject shoot2;
    public GameObject shoot3;
    public GameObject shoot4;
    public GameObject shoot5;

    

   

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

    public void FireShotgun()
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Instantiate(shoot3, new Vector3(playerPos.x, playerPos.y), Quaternion.identity);
        GameObject shot2 = Instantiate(shoot3, new Vector3(playerPos.x, playerPos.y), Quaternion.identity);
        shot2.transform.Rotate(0, 0, 16);
        GameObject shot3 = Instantiate(shoot3, new Vector3(playerPos.x, playerPos.y), Quaternion.identity);
        shot3.transform.Rotate(0, 0, -16);
    }
    public void FirePlasma()
    {

    }

    public void FireRifle()
    {

    }
}
