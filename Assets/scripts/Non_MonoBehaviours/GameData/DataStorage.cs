using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JsonData
{

    public interface IData
    {
        void Write();
    }

    public class CharacterData : IData
    {
        private string path;
        public short hairstyleIndex;

        public CharacterData()
        {
            path = Application.persistentDataPath + "/" + this.GetType().Name.ToLower() + ".json";
        }

        public void Write()
        {
            string json = JsonUtility.ToJson(this, true);
            System.IO.File.WriteAllText(path, json);
        }

        public CharacterData Read()
        {
            string data = System.IO.File.ReadAllText(path);
            return JsonUtility.FromJson<CharacterData>(data);
        }


    }
}
