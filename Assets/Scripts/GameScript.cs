using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject save;
    public void Reset()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Save");        
        Destroy(gameObjects[0]);
        Debug.Log("Instantiate save");
        Instantiate(save);
    }
}
