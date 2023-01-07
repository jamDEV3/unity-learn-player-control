using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public bool camToggle = true;

    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = camera1.enabled;
        camera2.enabled = !camera2.enabled;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            camToggle = !camToggle;

            camera1.enabled = camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && !camToggle)
        {

            camToggle = !camToggle;

            camera1.enabled = !camera1.enabled;
            camera2.enabled = camera2.enabled;


        }
    }
}
