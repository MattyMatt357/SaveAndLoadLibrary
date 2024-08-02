using System;
using System.Diagnostics;
using UnityEngine;

namespace SavingAndLoadingLibrary
{
    public class SavingSystem: MonoBehaviour
    {
        public void SaveJson<T>(T savedObj, string path)
        {
            string filepath = Application.persistentDataPath + path;
            string playerData = JsonUtility.ToJson(savedObj, true);
            System.IO.File.WriteAllText(filepath, playerData);
        }

        public void LoadJson<T>(T savedObj, string path)
        {
            string jsonFile = Application.persistentDataPath + path;
            string loadedObject = System.IO.File.ReadAllText(jsonFile);
            JsonUtility.FromJsonOverwrite(loadedObject, savedObj);

        }
    }

}
