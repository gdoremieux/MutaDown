using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiAI : MonoBehaviour
{
    private Rigidbody2D enemy;
    public float speed;
    public float maxSpeed;
    Vector2 move = new Vector2(1, 0);

	void Start ()
    {
        enemy = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        enemy.position += move * speed;

        enemy.velocity = (enemy.velocity.x > maxSpeed) ? new Vector2(maxSpeed, enemy.velocity.y) : enemy.velocity;
        enemy.velocity = (enemy.velocity.x < -maxSpeed) ? new Vector2(-maxSpeed, enemy.velocity.y) : enemy.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision AI");
        if (collision.gameObject.tag != "Player")
            move.x *= -1;
    }
}
