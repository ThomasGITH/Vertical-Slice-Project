using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiButtonScript : MonoBehaviour
{
    public InputField _inputText;

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
    }

    public void RandomizeName()
    {
        randomName = randomNames[Random.Range(0, randomNames.Length)];
        _inputText.text = randomName;
        Debug.Log(randomName);
    }
}
