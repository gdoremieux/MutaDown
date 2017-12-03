using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string LevelName = "Enter level name here";
    public Vector3 posOfChar;

    private void Start()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = posOfChar;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
