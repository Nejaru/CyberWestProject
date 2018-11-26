using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 mouse;
    Vector2 directionVector;
    public float moveSpeed;
    Camera cam;
    

    // Use this for initialization
    void Start ()
    { 
    	cam = Camera.main;
    	float camDis = cam.transform.position.y - transform.position.y;
    	mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

		float AngleRad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x - transform.position.x);
		float angle = (180 / Mathf.PI) * AngleRad;

		transform.Rotate (0, 0, angle + 270);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        GameObject esObject = GameObject.Find("EnemySpawner1");
        enemySpawner es = esObject.GetComponent<enemySpawner>();
        if (collision.gameObject.tag == "Enemy")
        {
            es.score += 100;
            es.scoreText.text = "Score: " + es.score;
			Destroy (collision.gameObject);
			Destroy (gameObject);
		}
	
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
