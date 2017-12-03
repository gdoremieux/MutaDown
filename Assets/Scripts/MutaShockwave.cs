using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutaShockwave : MonoBehaviour {

    public float radius = 5f;
    public float power = 20f;
    // Use this for initialization
    void Start () {
        GameObject.Find("Main Camera").GetComponent<HUD>().MutUIPushEnabled();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("p"))
        {
            Vector2 explosionPos = transform.position;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, radius);
            foreach (Collider2D hit in colliders)
            {
                Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();
                if (rb != null)
                    AddExplosionForce(rb, power * 100, explosionPos, radius);
            }
        }
    }

    public static void AddExplosionForce(Rigidbody2D body, float expForce, Vector3 expPosition, float expRadius)
    {
        var dir = (body.transform.position - expPosition);
        float calc = 1 - (dir.magnitude / expRadius);
        if (calc <= 0)
        {
            calc = 0;
        }

        body.AddForce(dir.normalized * expForce * calc);
    }
}
