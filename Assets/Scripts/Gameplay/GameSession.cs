using Assets.Scripts.com.DA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;

    public System.Action OnSessionStart;
    public System.Action OnSessionEnd;

    [HideInInspector]public float timeLeft = 0;

    [SerializeField]public GameSessionData GameSessionData;

    [SerializeField]public List<SpammerData> spamer;


    public enum SessionState
    {
        Paused,
        Active,
        Finished
    }

    private SessionState _state = SessionState.Paused;

    private void Awake()
    {
        Instance = this;
        UpdateSpamers();
    }

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = GameSessionData.TimeLenght;
        
        StartSession();
    }

    // Update is called once per frame
    void Update()
    {
        if( _state == SessionState.Active )
        {
            timeLeft -= Time.deltaTime;
            
            if( timeLeft <= 0 )
            {
                timeLeft = 0;
                EndSession();
            }
        }
    }


    void StartSession()
    {
        _state = SessionState.Active;

        if( OnSessionStart != null )
        {
            OnSessionStart();
        }
    }

    void EndSession()
    {
        if( OnSessionEnd != null )
        {
            OnSessionEnd();
        }
    }

    void UpdateSpamers() {
        int spm = GameSessionData.SpamPumkins;
        for (int i = 0; i < spamer.Count; i++)
        {
            if (spm > 0)
                spm--;
            else { 
                spamer[i].spamer.SetActive(false);
                spamer[i].spamer.GetComponent<EnemySpawner>().points = spamer[i].points;
            }
        }
    }

    [System.Serializable]
    public class SpammerData {
        public GameObject spamer;
        public int points;
    }
}
