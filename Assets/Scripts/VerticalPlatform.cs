using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{

	private Rigidbody2D enemy;
    public float speed;
    public float maxSpeed;
    Vector2 move = new Vector2(0, 1);

    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        enemy.position += move * speed;

        enemy.velocity = (enemy.velocity.y > maxSpeed) ? new Vector2(maxSpeed, enemy.velocity.y) : enemy.velocity;
        enemy.velocity = (enemy.velocity.y < -maxSpeed) ? new Vector2(-maxSpeed, enemy.velocity.y) : enemy.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
            move.y *= -1;
    }
}
