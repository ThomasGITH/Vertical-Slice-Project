using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiButtonScript : MonoBehaviour
{
    public InputField _inputText;
    private GameObject demonDude;

    private string[] randomNames =
    {
        "Jaina",
        "Sargeras",
        "Maiev",
        "Serpentis",
        "Illidan",
        "Mankrik",
        "Kaelthas",
        "Cthun",
        "Stormsong",
        "Stormstout",
        "Sylvanas",
        "Voljin",
        "Mrsmite",
    };

    string randomName = "";

    public void Start()
    {
        //nameText = GameObject.Find("Name_InputField").GetComponentInChildren<Text>();
        demonDude = GameObject.FindGameObjectWithTag("CharacterModel");
    }
    
    public void RandomizeName()
    {
        randomName = randomNames[Random.Range(0, randomNames.Length)];
        _inputText.text = randomName;
        Debug.Log(randomName);
    }

    public bool clockwise;

    public void rotateClockwise()
    {
    }

    public void rotateCounterClockwise()
    {
    }

    public void rotate()
    {
        if(clockwise)
        {
            demonDude.transform.Rotate(0, 2, 0);
        }
        else
        {
            demonDude.transform.Rotate(0, -2, 0);
        }
    }

}
