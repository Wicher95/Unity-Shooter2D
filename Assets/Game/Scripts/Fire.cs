using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public bool isFiring;

    public Bullet pocisk;
    private float bulletSpeed = 10f;

    private float timeBetweenShots = 0.2f;
    private float shotCounter;

    public Transform firePoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                Bullet newBullet = Instantiate(pocisk, firePoint.position, firePoint.rotation) as Bullet;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter -= Time.deltaTime;
        }
	}
}
