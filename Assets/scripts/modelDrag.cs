using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelDrag : MonoBehaviour
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
        if (mouseHold)
        {
            mouseOffset = (Input.mousePosition - mouseReference);

            rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;

            transform.Rotate(rotation);
            mouseReference = Input.mousePosition;
        }
    }

    private void OnMouseDown()
    {
        mouseHold = true;
        mouseReference = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseHold = false;
    }

}