using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaFlamethrower : MonoBehaviour {

    // Use this for initialization
	void Start () {
        transform.GetChild(3).gameObject.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIFlameEnabled();
    }

    // Update is called once per frame
    void Update () {
        
    }
}
