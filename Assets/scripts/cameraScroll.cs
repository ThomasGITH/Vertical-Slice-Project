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
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f && transform.position.y < 17.07f)
        {
            transform.position += dif;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0.0f && transform.position.y > 7.07f)
        {
            transform.position -= dif;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < 17.07f)
        {
            transform.position += dif;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > 7.07f)
        {
            transform.position -= dif;
        }
    }

}
