using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Mutagenes = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 50), "Mutagenes: " + Mutagenes);
    }
}
