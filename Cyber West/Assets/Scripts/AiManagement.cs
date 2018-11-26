using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManagement : MonoBehaviour
{
    public float speed;
	public float distance; 
	private Transform target;
	public  float turnRate;
	public float looking;
	public float attacktTime;
	private float lastAttack = 0;
	public float attackRange;
	public float attackDelay;
	public GameObject projectile;
	public float bulletForce;

	void Start ()
	{
		// Checks who is the target which is the player
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

	}

	void Update ()
	{
		// Following Player around and targeting them
		if (Vector2.Distance (transform.position, target.position) > distance)
        { 
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
	
		
		}


		float distanceToPlayer = Vector2.Distance (transform.position, target.position);
		if ( distanceToPlayer < attackRange)
        {
			// Facing towards player
			Vector3 playerPos = target.position - transform.position;
			float angle = (Mathf.Atan2 (playerPos.y, playerPos.x) * Mathf.Rad2Deg) - looking;
			Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.RotateTowards (transform.rotation, q, turnRate * looking * Time.deltaTime);

		
			//Attacking the player 
			if (distance <= attackRange && (Time.time - lastAttack) > attackDelay)
            { 
				Shoot();
			}
		}
	}
	void  Shoot() 
	{
		//resests the time so we can shoot in incriments
		lastAttack = Time.time;
		Instantiate(projectile, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);   

	}
}

	

