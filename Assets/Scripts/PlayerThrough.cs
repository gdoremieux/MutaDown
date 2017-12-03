using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrough : MonoBehaviour
{
    BoxCollider2D box;

    void Start()
    {
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("ENTERS COLLISION WITH PLAYER");
            box.isTrigger = true;           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("EXITS TRIGGER WITH PLAYER");
            box.isTrigger = false;
        }
    }

    /*void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("EXITS COLLISION WITH PLAYER");
            box.isTrigger = false;
        }
    }*/
}
