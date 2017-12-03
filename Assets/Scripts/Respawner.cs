using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameScript game;
    public Vector2 pos;
    bool passed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && passed == false)
        {
            passed = true;
            Debug.Log("ENTERED RESPAWNER");
            //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            other.transform.position = pos;
            other.gameObject.GetComponent<PlayerStats>().lifes -= 1;
            other.gameObject.GetComponent<PlayerStats>().health = 5;
            if (game)
            {
                game.Reset();
            }
        }
    }

    void Update()
    {
        passed = false;    
    }
}
