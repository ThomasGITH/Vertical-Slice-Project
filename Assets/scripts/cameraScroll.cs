using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    private Vector3 dif, targetPos;
    const float difference = 350;
    private short index = 0;
    private float velocity;

    void Start()
    {
        dif = new Vector3(0.0f, difference, 0.0f);
        targetPos = transform.position;
        velocity = 800;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            if (index < 2)
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

        transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);
    }

    public void MoveUp()
    {
        //transform.position += dif;
        targetPos = transform.position + dif;
    }

    public void MoveDown()
    {
        //transform.position -= dif;
        targetPos = transform.position - dif;
    }

}
