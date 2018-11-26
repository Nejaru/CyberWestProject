using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour {

	public float moveSpeed;
	public GameObject target;

	// Use this for initialization
	void Start ()
	{ 


		target = GameObject.FindGameObjectWithTag ("Player");
		float AngleRad = Mathf.Atan2 (target.transform.position.y - transform.position.y, target.transform.position.x - transform.position.x);
		float angle = (180 / Mathf.PI) * AngleRad;

		transform.Rotate (0, 0, angle + 270);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		
		
        if (collision.gameObject.tag == "Building")
        {
            Destroy(gameObject);

        }
    }


	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.up * Time.deltaTime * moveSpeed;
	}
}
