using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JsonData;

public class uiButtonScript : MonoBehaviour
{
    public InputField _inputText;
    private RandomStringField randomName;
    public uint hairstyle, skincolor, beep, boop;
    private CharacterData charData;

    public Button male, female;

    public void Start()
    {
        randomName = new RandomStringField(_inputText, "Assets/other/namelist.txt");
        charData = new CharacterData();
    }
    
    public void RandomizeName()
    {
        randomName.Click();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            charData.hairstyleIndex = 3;
            charData.Write();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            print(charData.Read().hairstyleIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }



    }



}
