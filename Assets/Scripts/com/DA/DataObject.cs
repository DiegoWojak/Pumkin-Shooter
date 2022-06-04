using System.IO;
using UnityEngine;

namespace Assets.Scripts.com.DA
{
    //[CreateAssetMenu(menuName = "Data/AccessDataObject")]
    public abstract class DataObject : ScriptableObject
    {
        public string Name => _name;
        [SerializeField] private string _name; 

        [ContextMenu("Save")]
        public void SaveState()
        {
            var json = JsonUtility.ToJson(this);
            File.WriteAllText(GetFilePath(), json);
            Debug.Log(GetFilePath());
        }

        [ContextMenu("Load")]
        public void LoadState()
        {
            var json = File.ReadAllText(GetFilePath());
            JsonUtility.FromJsonOverwrite(json, this);
        }

        private string GetFilePath()
        {
            return (Application.persistentDataPath + $"/{Name}.so");
        }
    }
}
