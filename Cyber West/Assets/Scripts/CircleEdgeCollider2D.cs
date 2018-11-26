using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof (Rigidbody2D), typeof(EdgeCollider2D))]
public class CircleEdgeCollider2D : MonoBehaviour {

    public float radius = 1.0f;
    public Vector2 offset = new Vector2(0.0f, 0.0f);
    public int NumPoints = 32;

    EdgeCollider2D EdgeCollider;
    float currentRadius = 0.0f;

	// Use this for initialization
	void Start ()
    {
        CreateCircle();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (NumPoints != EdgeCollider.pointCount || currentRadius != radius)
        {
            CreateCircle();
        }
	}

    void CreateCircle()
    {
        Vector2[] edgePoints = new Vector2[NumPoints + 1];
        Vector2[] h = new Vector2[3];
        EdgeCollider = GetComponent<EdgeCollider2D>();

        for (int i = 0; i <= NumPoints; i++)
        {
            float angle = (Mathf.PI * 2.0f / NumPoints) * i;
            
            /*if (i%2 != 0)
            {
                edgePoints[i] = new Vector2((Mathf.Sin(angle)), (Mathf.Cos(angle))) * radius;
            }
            else
            {
                edgePoints[i] = new Vector2(((Mathf.Sin(angle)) + offset.x), ((Mathf.Cos(angle)) + offset.y)) * radius;
            }*/
            edgePoints[i] = new Vector2((Mathf.Sin(angle) + offset.x), (Mathf.Cos(angle) + offset.y)) * radius;
        }

        EdgeCollider.points = edgePoints;
        currentRadius = radius;
    }

    Bullet Bullet1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Physics2D.IgnoreCollision(Bullet1.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
