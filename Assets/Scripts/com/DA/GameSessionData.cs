using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.com.DA
{   
    [CreateAssetMenu(menuName = "Data/GameSession")]
    [System.Serializable]
    public class GameSessionData : DataObject
    {
        [SerializeField] private float _timeLenght = 60.0f;
        [Range(1, 3)]
        [SerializeField] private int _spamPumkins = 3;

        public float TimeLenght { get => _timeLenght; }

        public int SpamPumkins { get => _spamPumkins; }
    
    }
}
