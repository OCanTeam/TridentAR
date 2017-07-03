using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    //[SerializeField]
    //private float speed = 5;

    [SerializeField]
    private float _bulletLifeTime = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject.Find("ScriptsContainer").GetComponent<EnemySpawn>().enemyDieCount++;
            Destroy(other.gameObject);
        }
    }

    private void OnEnable()
    {
        Invoke("Destroy", _bulletLifeTime);
    }
    void Destroy()
    {
        Destroy(gameObject);
        //gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
