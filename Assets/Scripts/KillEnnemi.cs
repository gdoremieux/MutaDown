using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnnemi : MonoBehaviour
{
    // Use this for initialization
    public GameObject enemy;
	void OnTriggerEnter2D (Collider2D other)
    {
	    if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<PlayerStats>().canKillOnJump)
        {
          Debug.Log("DESTROY ENEMY");
          Destroy(gameObject);
        }
	}
	
}
