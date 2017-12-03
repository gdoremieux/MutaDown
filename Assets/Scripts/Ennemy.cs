using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour {

    public int lifePoint = 2;
    public int damages = 1;
    public float radius = 90f;
    public float power = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lifePoint == 0)
            Destroy(gameObject);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        bool playerTouched = false;
        if (other.gameObject.tag == "Player")
        {
            Vector2 explosionPos = transform.position;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, radius);
            foreach (Collider2D hit in colliders)
            {
                Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();
                if (rb != null && rb.tag == "Player")
                {
                    playerTouched = true;
                    AddExplosionForce(rb, power * 10, explosionPos, radius);
                }
            }
        }
        if (playerTouched)
            other.gameObject.GetComponent<PlayerStats>().PlayerHit();
    }

    public static void AddExplosionForce(Rigidbody2D body, float expForce, Vector3 expPosition, float expRadius)
    {
        var dir = (body.transform.position - expPosition);
        float calc = 1 - (dir.magnitude / expRadius);
        if (calc <= 0)
        {
            calc = 0;
        }

        body.AddForce(dir.normalized * expForce * calc);
    }
}
