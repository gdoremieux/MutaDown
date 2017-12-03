using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour {

    public float fireRate = 0;
    public float damage = 10;
    public LayerMask whatToHit;

    public Transform BulletTrailPrefab;
    float timeToSpawnEffect = 0;
    public float effectSpawnRate = 10;
    float timeToFire = 0;
    Transform firePoint;
    public bool facingRight = true;
	// Use this for initialization
	void Awake () {
        firePoint = GameObject.Find("FirePoint").transform;
        if (firePoint == null)
        {
            Debug.Log("No FirePoint found");
        }
	}
	
	// Update is called once per frame
	void Update () {
        facingRight = GetComponentInParent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_FacingRight;

        if (fireRate == 0)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Shoot();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.P) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
	}

    void Shoot()
    {
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        Vector2 direction;
        if (facingRight)
            direction = new Vector2(firePoint.position.x + 1, firePoint.position.y);
        else
            direction = new Vector2(firePoint.position.x - 1, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, direction - firePointPosition, 100, whatToHit);
        if (Time.time >= timeToSpawnEffect)
        {
            Effect();
            timeToSpawnEffect = Time.time + 1 / effectSpawnRate;
        }
    }

    void Effect()
    {
        float new_x;
        if (facingRight)
            new_x = firePoint.position.x + 1;
        else
            new_x = firePoint.position.x - 3;
        Vector3 newPosition = new Vector3(new_x, firePoint.position.y, firePoint.position.z);
        var bulletTrail = Instantiate(BulletTrailPrefab, newPosition, firePoint.rotation);
        bulletTrail.transform.parent = gameObject.transform;
    }
}
