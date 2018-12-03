using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraScroll : MonoBehaviour
{
    private Vector3 dif, targetPos;
    const float difference = 175, velocity = 1000;
    private short index = 0;
    private Text _hsText; // hair style text

    int hsIndex = 3; // hair style number

    void Start()
    {
        _hsText = GameObject.Find("HairstyleIndexText").GetComponent<Text>();
        dif = new Vector3(0.0f, difference, 0.0f);
        targetPos = transform.position;
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
        hsIndex += 1;
        _hsText.text = hsIndex.ToString();
    }

    public void MoveDown()
    {
        //transform.position -= dif;
        targetPos = transform.position - dif;
        hsIndex -= 1;
        _hsText.text = hsIndex.ToString();
    }

}
