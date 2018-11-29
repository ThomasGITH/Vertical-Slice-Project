using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    private Vector3 dif;

    void Start()
    {
        dif = new Vector3(0.0f, 5.0f, 0.0f);
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") > 0.0f) && transform.position.y < 31.99f)
        {
            MoveUp();
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") < 0.0f) && transform.position.y > 1.99f)
        {
            MoveDown();
        }
    }

    public void MoveUp()
    {
        transform.position += dif;
    }

    public void MoveDown()
    {
        transform.position -= dif;
    }


}
