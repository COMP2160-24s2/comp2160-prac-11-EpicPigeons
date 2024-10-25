using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private float sensitivity = 120;
    private Actions actions;
    private InputAction scrollAction;

    void Awake()
    {
        actions = new Actions();
        scrollAction = actions.camera.zoom;
    }

    void OnEnable()
    {
        actions.camera.Enable();
    }

    void OnDisable()
    {
        actions.camera.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float zoom = 1 + (scrollAction.ReadValue<float>()/sensitivity);
        
        Camera.main.orthographicSize *= zoom;
        Camera.main.fieldOfView *= zoom;

        if(Camera.main.orthographicSize < 0)
        {
            Camera.main.orthographicSize = 0;
        } 
        else if(Camera.main.orthographicSize > 10)
        {
            Camera.main.orthographicSize = 10;
        }
        if(Camera.main.fieldOfView < 0)
        {
            Camera.main.fieldOfView = 0;
        } 
        else if(Camera.main.fieldOfView > 100)
        {
            Camera.main.fieldOfView = 100;
        }
    }
}
