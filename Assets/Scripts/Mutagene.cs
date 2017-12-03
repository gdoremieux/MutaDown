using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutagene : MonoBehaviour {

    public string mutagene;
    private bool hasEnter = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasEnter)
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D other)
    {
        hasEnter = true;
        if (mutagene == "MutaFlamethrower")
            other.gameObject.AddComponent<MutaFlamethrower>();
        if (mutagene == "MutaHigherJump")
            other.gameObject.AddComponent<MutaHigherJump>();
        if (mutagene == "MutaInvisible")
            other.gameObject.AddComponent<MutaInvisible>();
        if (mutagene == "MutaKillJump")
            other.gameObject.AddComponent<MutaKillJump>();
        if (mutagene == "MutaShockwave")
            other.gameObject.AddComponent<MutaShockwave>();
        if (mutagene == "MutaShotgun")
            other.gameObject.AddComponent<MutaShotgun>();
        if (mutagene == "MutaSpeed")
            other.gameObject.AddComponent<MutaSpeed>();
        other.GetComponent<PlayerStats>().Mutate();
        Destroy(gameObject);
    }
}
