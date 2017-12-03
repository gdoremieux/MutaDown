using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public GameObject platform;
    public AudioClip sound;
    public bool hasPlayed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!hasPlayed)
            {
                GetComponent<AudioSource>().PlayOneShot(sound);
                hasPlayed = true;
            }

            platform.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
