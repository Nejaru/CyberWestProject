using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : PlayerBulletSpawner {

    public float speed = 5f;
	private bool laser = false;
    private bool shotgun = false;
    private bool plasma = false;
    private bool rifle = false;
    private bool standard = true;
	public int laserCount;
    public int plasmaCount;
    public int shotgunCount;
    public int rifleCount;
	private int ammo;
	public int health;
    public GameObject character;
    public Sprite hitOnce;
    public Sprite hitTwice;
    public Animator animator;

    AudioSource sndShoot;
    AudioSource sndShoot2;

    public void Start()
    {
        AudioSource[] src = GetComponents<AudioSource>();

        sndShoot = src[0];
        sndShoot2 = src[1];
    }

    // Update is called once per frame
    void Update ()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 newPos = transform.position;
        newPos += Vector3.right * Time.deltaTime * speed * moveX;
        newPos += Vector3.up * Time.deltaTime * speed * moveY;
        transform.position = newPos;

        animator.SetFloat("Speed", Mathf.Abs(moveX + moveY));
        animator.SetInteger("Health", health);



        if(Input.GetButtonDown("Fire1") && standard)
        {
            Fire();
            sndShoot.Play();
        }
		if(Input.GetButtonDown("Fire1") && laser)
		{
			FireLaser();
			ammo--;
			if (ammo <= 0)
			{
				laser = false;
                standard = true;
			}
            sndShoot2.Play();
        }
        if(Input.GetButtonDown("Fire1") && shotgun)
        {
            FireShotgun();
            ammo--;
            if(ammo<=0)
            {
                shotgun = false;
                standard = true;
            }
        }
        if (Input.GetButtonDown("Fire1") && plasma)
        {
            FirePlasma();
            ammo--;
            if (ammo <= 0)
            {
                plasma = false;
                standard = true;
            }
        }
        if (Input.GetButtonDown("Fire1") && rifle)
        {
            FireRifle();
            ammo--;
            if (ammo <= 0)
            {
                rifle = false;
                standard = true;
            }
        }

    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "laserUpgrade") {

			laser = true;
            standard = false;
			ammo = laserCount;
		}
        if (collision.gameObject.tag == "shotgunUpgrade")
        {

            shotgun = true;
            standard = false;
            ammo = shotgunCount;
        }
        if (collision.gameObject.tag == "plasmaUpgrade")
        {

            plasma = true;
            standard = false;
            ammo = plasmaCount;
        }
        if (collision.gameObject.tag == "rifleUpgrade")
        {

            rifle = true;
            standard = false;
            ammo = rifleCount;
        }

        if (collision.gameObject.tag == "badBullet") {

			health--;

            if (health == 2)
            {
                character.GetComponent<SpriteRenderer>().sprite = hitOnce;
                animator.SetInteger("Health", health);
            }

            if (health == 1)
            {
                character.GetComponent<SpriteRenderer>().sprite = hitTwice;
                animator.SetInteger("Health", health);
            }

            if (health <= 0)
            {
                Destroy(gameObject);
			}

        }
	}
}