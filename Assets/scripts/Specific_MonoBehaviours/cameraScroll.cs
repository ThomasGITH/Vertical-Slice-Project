using UnityEngine;
using UnityEngine.UI;
using JsonData;

public class cameraScroll : MonoBehaviour
{
    private Vector3 dif, targetPos;
    const float difference = 175, velocity = 1000;
    private short index = 3;
    private short position;
    private Text _hsText; // hair style text
    private CharacterData chardata;

    int hsIndex = 3; // hair style number

    void Start()
    {
        _hsText = GameObject.Find("HairstyleIndexText").GetComponent<Text>();
        dif = new Vector3(0.0f, difference, 0.0f);
        targetPos = transform.position;
        chardata = new CharacterData();
        position = chardata.Read().hairstyleIndex;
    }

    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            if (index < 2)
            {
                position--;
                print("THis object is: " + this.GetType().Name);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            if (index > -2)
            {
                position++;

            }
        }

        int difference = index - position;
        if(difference > 0)
        {
            //MoveDown();
        }
        else if(difference < 0)
        {
         //   MoveUp();
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);

        */
    }
    
    public void MoveUp()
    {
        index++;
        targetPos = transform.position - dif;
        hsIndex -= 1;
        _hsText.text = hsIndex.ToString();
    }

    public void MoveDown()
    {
        index--;
        targetPos = transform.position + dif;
        hsIndex += 1;
        _hsText.text = hsIndex.ToString();
    }

}
