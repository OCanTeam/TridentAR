using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RobotHint : MonoBehaviour {

    public float interval = 5;
    public float speed = 0.1f;

    [SerializeField]
    private Sprite[] _sprites;

    private float _time;
    private float _time2;
    private void Start()
    {
        StartCoroutine(Move());

    }

    IEnumerator Move()
    {
        speed *= -1; 
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Move());
    }
    // Update is called once per frame
    void Update()
    {
         transform.position += new Vector3(0, speed, 0);

        _time++;

        if (_time >= 60 * Random.Range(3, interval))
        {
            _time2++;
            gameObject.GetComponent<Image>().sprite = _sprites[1];

            if (_time2 >= 3.0f)
            {
                _time = 0;
                _time2 = 0;
                gameObject.GetComponent<Image>().sprite = _sprites[0];
            }
        }
    }
}
