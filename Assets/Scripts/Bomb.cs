using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public float radius = 0.001f;
    public float power = 5f;
    public Sprite explosion;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(IsExploding(other));
        }
    }

    IEnumerator IsExploding(Collider2D other)
    {
        bool playerTouched = false;
        Rigidbody2D player = null;
        yield return new WaitForSeconds(1);
        Vector2 explosionPos = transform.position;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, radius / 2);
        foreach (Collider2D hit in colliders)
        {
            Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                if (rb.tag == "Player")
                {
                    playerTouched = true;
                    player = rb;
                }
                AddExplosionForce(rb, power * 100, explosionPos, radius);
            }
        }
        if (playerTouched)
            player.GetComponent<PlayerStats>().health -= 1;
        GetComponent<SpriteRenderer>().sprite = explosion;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
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
