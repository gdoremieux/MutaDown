using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public string dialogue;
    public DialogueManager dMan;

    // Use this for initialization
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dMan.ShowBox(dialogue);
        }
    }

}
