using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaSpeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInParent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_MaxSpeed = 15;
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUISpeedEnabled();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
