using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectUsingButtons : MonoBehaviour {

    public GameObject Model;
    public float sensitivity;
    public bool Clockwise;

    private bool hold;

    private void Update()
    {
        if (hold)
        {
            Model.transform.Rotate(0, (Clockwise ? 1 : -1) * sensitivity, 0);
        }
    }

    public void press()
    {
        hold = true;
    }

    public void release()
    {
        hold = false;
    }

}
