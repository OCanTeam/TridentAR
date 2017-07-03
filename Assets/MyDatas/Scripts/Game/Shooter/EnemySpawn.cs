//====================================
//         EnemySpawn.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/16
//====================================
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    //private List<GameObject>_enemies;
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private float _spawnTime = 1f;

    private Quest _quest;

    private float _time;

    private bool _done = false;

    public int enemyDieCount = 0;
    [SerializeField]
    private float _minX,_minZ;
    [SerializeField]
    private float _maxX, _maxZ;

    // Use this for initialization
    void Start () {
        _quest = gameObject.GetComponent<Quest>();

    }
	
	// Update is called once per frame
	void Update () {
        _time++;

        if (enemyDieCount < 10)
        {
            if (_time >= 60 * _spawnTime)
            {
                _time = 0;

                //GameObject enemy = Instantiate(_enemyPrefab, new Vector3(Random.Range(_minX, _maxX), 1f, Random.Range(_minZ, _maxZ)), Quaternion.identity);
                GameObject enemy = ObjectPooler.current.GetPooledObject();

                if (!enemy) return;
                //enemy.transform.parent = gameObject.transform;
                enemy.transform.position = new Vector3(Random.Range(_minX, _maxX), 1f, Random.Range(_minZ, _maxZ));
                enemy.transform.rotation = Quaternion.identity;
                enemy.SetActive(true);
            }
        }
        else
        {
            if (!_done)
            {
                _quest.isGameClear(true);
                _done = true;
            }
        }
	}
}
