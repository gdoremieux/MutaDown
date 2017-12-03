using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaInvisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("ContainerInvisibleBlocks").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIInvisibleEnabled();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
