using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*Vector2 lookValue;

    public Camera[] cameras = new Camera[2];
    Camera currentCamera;
    public Canvas canvas;

    int cameraViewIndex = 0;
    
    public void Look()
    {
        lookValue = context.ReadValue<Vector2>();
    }

    public void ChangeCameraView()
    {
        if(context.action.phase == InputActionPhase.Performed)
        {
            cameraViewIndex = (++cameraViewIndex) % 3;
            SetCamera();
        }
    }

    void SetCamera()
    {
        for(int i = 0; i < cameras.Length; i++)
        {
            if(i == cameraViewIndex)
            {
                currentCamera = cameras[i];
                canvas.worldCamera = currentCamera;
            }
            cameras[i].enabled = (i == cameraViewIndex);
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        //SetCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
