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

    public Button male, female;

    public void Start()
    {
        randomName = new RandomStringField(_inputText, "Assets/other/namelist.txt");
    }
    
    public void RandomizeName()
    {
        randomName.Click();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            JsonData.CharacterData chardata = new JsonData.CharacterData();
            chardata.hairstyleIndex = 2;
            chardata.Write();
            print(Application.persistentDataPath);
            Application.Quit();
        }
    }



}
