using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationInfo : MonoBehaviour {

    private GameObject[] models;
    private JsonData.CharacterData chardata;
    private int activeIndex;

    private void Start()
    {
        models = new GameObject[5];
        for(byte i = 0; i < transform.childCount; i++)
        {
            models[i] = transform.GetChild(i).gameObject;
        }

        chardata = new JsonData.CharacterData();
        activeIndex = chardata.Read().hairstyleIndex;
    }

    private void Update()
    {
        activeIndex = chardata.Read().hairstyleIndex;

        models[activeIndex].SetActive(true);
        for(byte i = 0; i < transform.childCount; i++)
        {
            if(i != activeIndex)
            {
                models[i].SetActive(false);
                models[i].transform.rotation = models[activeIndex].transform.rotation;
            }
        }
    }
}
