using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxing : MonoBehaviour
{

    public Transform[] backgrounds;
    private float[] parallaxScales;
    public float smoothing = 1f;

    private Transform cam;
    private Vector3 prevCamPos;

    void Awake()
    {
        cam = Camera.main.transform;
    }


    // Use this for initialization
    void Start()
    {
        prevCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];
        for (int a = 0; a < backgrounds.Length; a++)
        {
            parallaxScales[a] = backgrounds[a].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int a = 0; a < backgrounds.Length; a++)
        {
            float parallax = (prevCamPos.x - cam.position.x) * parallaxScales[a];

            float backgroundTargetPosX = backgrounds[a].position.x + parallax;

            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[a].position.y, backgrounds[a].position.z);
            backgrounds[a].position = Vector3.Lerp(backgrounds[a].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        prevCamPos = cam.position;

    }
}