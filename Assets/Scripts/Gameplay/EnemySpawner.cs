using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint = null;

    [SerializeField] private Enemy _enemyPrefab = null;

    private Enemy _lastSpawned = null;
    [SerializeField] float _spamDelay = 5f;
    [SerializeField] public int points = 10;
    private GameObject _lastgo = null;
    private HUD hud_;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        hud_ = GameObject.Find("HUDCanvas").GetComponent<HUD>();
    }

    void SpawnEnemy()
    {
        if (_lastgo != null) Destroy(_lastgo);

        _lastSpawned = Instantiate( _enemyPrefab, _spawnPoint.position, _spawnPoint.rotation );
        _lastgo = _lastSpawned.gameObject;
        _lastSpawned.OnDieCallback = ()=> {
            GainPoints();
            this.StartCoroutine(Respawm(_spamDelay)); 
        };
    }

    private void GainPoints() {
        hud_.SetPoints(points);
    }

    private IEnumerator Respawm(float _time)
    {
        yield return new WaitForSeconds(_time);
        SpawnEnemy();
    }
}
