using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JsonFormat;

public static class DataManagement {
    
    public static CharacterData charData;
    public static TestData testData;
    private static List<IData> dataList;

    static DataManagement()
    {
        dataList = new List<IData>();

        charData = new CharacterData();
        testData = new TestData();

        dataList.Add(charData);
        dataList.Add(testData);
    }

    public static void Write(Datatype datatype)
    {
        int index = (int)datatype;
        string path = Application.persistentDataPath + "/" + dataList[index].GetType().Name.ToLower() + ".json";
        System.IO.File.WriteAllText(path, JsonUtility.ToJson(dataList[index]));
        MonoBehaviour.print("Wrote object '" + dataList[index].GetType().Name + "' to: " + path);
    }

    public static void WriteAll()
    {
        dataList.Add(charData);
        dataList.Add(testData);

        for (byte i = 0; i < dataList.Count; i++)
        {
            string path = Application.persistentDataPath + "/" + dataList[i].GetType().Name.ToLower() + ".json";
            System.IO.File.WriteAllText(path, JsonUtility.ToJson(dataList[i]));
            MonoBehaviour.print("Wrote object '" + dataList[i].GetType().Name + "' to: " + path);
        }

        dataList.Clear();
    }

    public static void Read(Datatype datatype)
    {
        int index = (int)datatype;
        string path = Application.persistentDataPath + "/" + dataList[index].GetType().Name.ToLower() + ".json";

        //TEMPORARY SOLUTION: (there are more smooth ways to handle this)

        if (System.IO.File.Exists(path)) 
        {
            if (index == 0)
            {
                dataList[index] = JsonUtility.FromJson<CharacterData>(System.IO.File.ReadAllText(path));
            }
            else if (index == 1)
            {
                dataList[index] = JsonUtility.FromJson<TestData>(System.IO.File.ReadAllText(path));
            }
        }
        else
        {
            MonoBehaviour.print("Path '" + Application.persistentDataPath + "/" + dataList[index].GetType().Name.ToLower() + ".json" + "' does not exist.");
        }
    }

    public static void ReadAll()
    {
        //Improve later
        if (System.IO.File.Exists(Application.persistentDataPath + "/" + dataList[0].GetType().Name.ToLower() + ".json"))
        {
            string charpath = Application.persistentDataPath + "/" + dataList[0].GetType().Name.ToLower() + ".json";
            charData = JsonUtility.FromJson<CharacterData>(System.IO.File.ReadAllText(charpath));
        }
        else
        {
            MonoBehaviour.print("Path '" + Application.persistentDataPath + "/" + dataList[0].GetType().Name.ToLower() + ".json" + "' does not exist.");
        }

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + dataList[1].GetType().Name.ToLower() + ".json"))
        {
            string testpath = Application.persistentDataPath + "/" + dataList[1].GetType().Name.ToLower() + ".json";
            testData = JsonUtility.FromJson<TestData>(System.IO.File.ReadAllText(testpath));
        }
        else
        {
            MonoBehaviour.print("Path '" + Application.persistentDataPath + "/" + dataList[1].GetType().Name.ToLower() + ".json" + "' does not exist.");
        }

    }

    public static IData getData(Datatype datatype)
    {
        return dataList[(int)datatype];
    }
}