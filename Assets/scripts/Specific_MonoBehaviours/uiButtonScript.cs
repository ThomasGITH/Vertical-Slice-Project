using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiButtonScript : MonoBehaviour
{
    public InputField _inputText;
    private RandomStringField randomName;

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
            Application.Quit();
        }
    }

}
