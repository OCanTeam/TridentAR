using UnityEngine;
using UnityEngine.UI;

public class TraiText : MonoBehaviour {

    private Text _text;
    private GameManager _gm;

	// Use this for initialization
	void Start () {
        _gm = GameManager.instance;

        gameObject.GetComponent<Text>().text = _gm.Trai.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
