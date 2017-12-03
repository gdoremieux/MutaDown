using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaShotgun : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.GetChild(4).gameObject.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIShootGunEnabled();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
