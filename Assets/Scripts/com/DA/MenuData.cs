using System;
using UnityEngine;

namespace Assets.Scripts.com.DA
{
    [CreateAssetMenu(menuName = "Data/Menu")]
    public class MenuData : DataObject
    {
        [SerializeField] private string _title ,_version, _highscoreTitle;
        [SerializeField] private string _buttonName;
        public string Title { get => _title; }
        public string Version { get => _version;}
        public string HighscoreTitle { get => _highscoreTitle;}
        public string ButtonName { get => _buttonName;}


        public MenuData()
        {
            _title = "Pumkin Shooter";
            _version = "v0.9";
            _highscoreTitle = "High Score";
            _buttonName = "Start";
        }
    }
}
