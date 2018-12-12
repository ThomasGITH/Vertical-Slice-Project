using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelRotationByMouse : MonoBehaviour
{
    private Vector3 rotation, mouseOffset, mouseReference;
    public float sensitivity;
    private bool mouseHold;

    void Awake()
    {
        rotation = Vector3.zero;
        sensitivity = sensitivity > 0.0f ? sensitivity : 0.4f;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseHold = true;
            mouseReference = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            mouseHold = false;
        }

        if (mouseHold)
        {
            mouseOffset = (Input.mousePosition - mouseReference);
            rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;
            transform.Rotate(rotation);
            mouseReference = Input.mousePosition;
        }
    }

}
