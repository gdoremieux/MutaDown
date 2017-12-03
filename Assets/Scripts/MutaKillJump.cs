using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaKillJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInParent<PlayerStats>().canKillOnJump = true;
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIJumpKillEnabled();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
