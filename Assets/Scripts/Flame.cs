using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {

    private float timeTrigger = 0f;
    private bool trig = false;
    private Collider2D actualCollider;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (trig)
        {
            timeTrigger += Time.deltaTime;
            if (timeTrigger > 0.3f)
            {
                timeTrigger = 0f;
                actualCollider.gameObject.GetComponent<Ennemy>().lifePoint -= 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            trig = true;
            actualCollider = collision;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            trig = false;
            timeTrigger = 0f;
        }
    }
}
