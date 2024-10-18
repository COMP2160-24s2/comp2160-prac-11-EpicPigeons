using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    private float zoom;

    void Awake()
    {
        if(Camera.main.orthographic == true)
        {
            zoom = Camera.main.orthographicSize;
        } 
        else 
        {
            zoom = Camera.main.fieldOfView;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.orthographic == true)
        {
            Camera.main.orthographicSize = zoom;
        } 
        else 
        {
            Camera.main.fieldOfView = zoom;
        }
    }
}
