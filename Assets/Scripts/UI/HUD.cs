using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    [Header("Game Session Info")]
    [SerializeField] private GameSession _gameSession = null;
    [SerializeField] private Text _scoreValue = null;
    [SerializeField] private GameObject _timeRemaining = null;
    [SerializeField] private Text _timeRemainingValue = null;
    [Header("Game Over")]
    [SerializeField] private GameObject _gameOverScreen = null;
    private int _points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameSession.OnSessionStart += SessionStart;
        _gameSession.OnSessionEnd += HandleSessionEnded;

    }

    string GetFormattedTimeFromSeconds( float seconds )
    {
        return Mathf.FloorToInt( seconds / 60.0f ).ToString("0") + ":" + Mathf.FloorToInt( seconds % 60.0f ).ToString("00");
    }

    void HandleSessionEnded()
    {
        SetHighScore();
        _gameSession.OnSessionEnd -= HandleSessionEnded;
        _timeRemaining.SetActive(false);
        _gameOverScreen.SetActive(true);
    }

    void SessionStart() {
        _scoreValue.text = _points.ToString();
    }


    void SetHighScore() {
        int.TryParse(_scoreValue.text, out int result);

        if(PlayerPrefs.GetInt("highScore",0) < result)
            PlayerPrefs.SetInt("highScore",result);
    }
    // Update is called once per frame
    void Update()
    {
        _timeRemainingValue.text = GetFormattedTimeFromSeconds(_gameSession.timeLeft);
    }
    public void SetPoints(int points) {
        _points += points;
        _scoreValue.text = _points.ToString();
    }


    public void BackToMenu() {
        SceneManager.LoadScene(Constant.StartMenu);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(Constant.GameScene);
    }
}
