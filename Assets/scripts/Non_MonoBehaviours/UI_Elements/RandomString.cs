using UnityEngine;
using System.IO;

public class RandomString
{
    private string[] stringList;

    public RandomString(string path)
    {
        StreamReader reader = new StreamReader(path, true);
        string stream = reader.ReadToEnd();
        stringList = stream.Split(' ');
    }

    public string Activate() 
    {
        return stringList[Random.Range(0, stringList.Length)];
    }
}
