
using UnityEngine;
using System.Collections.Generic;
public class ObjectPooler : MonoBehaviour {

    public static ObjectPooler current;
    public int pooledAmount = 10;

    private List<GameObject> _pooledObjects; 

    [SerializeField]
    private GameObject _pooledObject;

    private void Awake()
    {
        current = this;
    }
    // Use this for initialization
    void Start ()
    {
        _pooledObjects = new List<GameObject>();
        for(int i = 0;i<pooledAmount;i++)
        {
            GameObject obj = Instantiate(_pooledObject);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
            _pooledObjects[i].transform.parent = gameObject.transform;
        }	
	}
	
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < _pooledObjects.Count; i++)
        {
            if(!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }
        return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
