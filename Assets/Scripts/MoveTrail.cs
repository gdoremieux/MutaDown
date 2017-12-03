using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrail : MonoBehaviour {

    public int moveSpeed = 150;
	// Update is called once per frame
	void Update () {
        transform.Translate((Vector3.left * Time.deltaTime * moveSpeed) * -1);

        Destroy(gameObject, 1);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            Debug.Log("ENNEMY TOUCHED");
            collision.gameObject.GetComponent<Ennemy>().lifePoint -= 1;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
