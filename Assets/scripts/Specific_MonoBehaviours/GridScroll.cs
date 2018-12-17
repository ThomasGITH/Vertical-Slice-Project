using UnityEngine;
using JsonData;
using UnityEngine.UI;

public class GridScroll : MonoBehaviour {

    const float HEIGHT_DIFFERENCE = 175;
    private float[] targetList;
    private int targetPosition = 2;
    private CharacterData chardata;
    private Text _hsText; // hair style text
    public Sprite up_grayed, up_active, down_grayed, down_active;
    private Image upButton, downButton;
    private AudioSource audio;

    void Start ()
    {
        chardata = new CharacterData();
        _hsText = GameObject.Find("HairstyleIndexText").GetComponent<Text>();
        upButton = GameObject.FindGameObjectWithTag("up").GetComponent<Image>();
        downButton = GameObject.FindGameObjectWithTag("down").GetComponent<Image>();
        audio = GetComponent<AudioSource>();

        targetList = new float[10];
        for(byte i = 0; i < targetList.Length; i++)
        {
            targetList[i] = (transform.position.y + (HEIGHT_DIFFERENCE * 2)) - (175 * i);
        }

        //Retreive hair-index from saved data
        targetPosition = -(chardata.Read().hairstyleIndex - 4);
    }

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            MoveUp();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            MoveDown();
        }
        
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, targetList[targetPosition]), 17);
        _hsText.text = (-(targetPosition - 5)).ToString();

        upButton.sprite = targetPosition == 4 ? up_grayed : up_active;
        downButton.sprite = targetPosition == 0 ? down_grayed : down_active;

    }

    public void MoveUp()
    {
        audio.Play();
        targetPosition += targetPosition < 4 ? 1 : 0;
    }

    public void MoveDown()
    {
        audio.Play();
        targetPosition += targetPosition > 0 ? -1 : 0;
    }

}
