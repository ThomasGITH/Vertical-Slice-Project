using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    private Vector3 dif;

    void Start()
    {
        dif = new Vector3(0.0f, 182.3055f, 0.0f);
    }

    short index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            if(index < 2)
            {
                index += 1;
                MoveDown();
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            if (index > -2)
            {
                index -= 1;
                MoveUp();
            }
        }

    }

    public void MoveUp()
    {
        transform.position -= dif;
    }

    public void MoveDown()
    {
        transform.position += dif;
    }

}
