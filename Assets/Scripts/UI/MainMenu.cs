using Assets.Scripts.com.DA;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Fields UI")]
    [SerializeField] private Text _title, _version, _highscoreTitle;
    [SerializeField] private Text _buttonText;
    [SerializeField] private Text _highScore = null;
    [Header("Button UI")]
    [SerializeField] private Button _startButton;
    [Space(5)]
    [Header("Data Information")]
    [SerializeField] private MenuData _data ;
    private MenuData Data 
    { 
        get 
        { 
            if (_data == null) {
                _data = new MenuData();
            }
            return _data;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateFields();
        UpdateButtonAction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateButtonAction() {
        _startButton.onClick.AddListener(()=> {
            SceneManager.LoadScene(Constant.GameScene);
        });

    }

    void UpdateFields() {
        _title.text = Data.Title;
        _version.text = Data.Version;
        _highscoreTitle.text = Data.HighscoreTitle;
        _buttonText.text = Data.ButtonName;
        _highScore.text = PlayerPrefs.HasKey("highScore") ? PlayerPrefs.GetInt("highScore").ToString() : 0.ToString();
    }
}
