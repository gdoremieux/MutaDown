using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaHigherJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInParent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_JumpForce = 1000;
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIJumpEnabled();
    }
}
