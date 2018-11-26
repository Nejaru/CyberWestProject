using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBehaviour : MonoBehaviour {

    public float upgradeSpeed = 5;
	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * upgradeSpeed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
