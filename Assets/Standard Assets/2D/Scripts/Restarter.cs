using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{

    
    public Vector2 pos;
    //public 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            //other.transform.position = pos;
            //GetComponent<>
        }
    }
}
