using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGuider : MonoBehaviour {

    [SerializeField]
    private float _typingSpeed = 0.1f;

    [SerializeField]
    private TextAsset[] _textFile;

    private GameManager _gm;

    private string _text;

    private Text _textForUI;


    // Use this for initialization
    void Start () {
        _gm = GameManager.instance;

        _textForUI = transform.GetChild(0).GetChild(0).GetComponent<Text>();
        _text = _textFile[_gm.Quest - 1].text;
        StartCoroutine(AutoType());
		
	}
    IEnumerator AutoType()
    {
        foreach(char letter in _text.ToCharArray())
        {
            _textForUI.text += letter;
            yield return new WaitForSeconds(_typingSpeed);
        }
    }

}
