using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueHint : MonoBehaviour {

    public GameObject textBox;
    public TextAsset textFile;
    public string[] textLines;

    public Text text;

    public int currentLine;
    public int endAtLine;

    [SerializeField]
    private float interval = 7;

    private float _time;

	// Use this for initialization
	void Start () {
        if(textFile)
        {
            textLines = textFile.text.Split('\n');
        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }		
	}
	
	// Update is called once per frame
	void Update () {
        _time++;

        if(_time >= 60 * interval)
        {
            currentLine = Random.Range(1, textLines.Length);
            _time = 0;
        }

        text.text = textLines[currentLine];

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    currentLine++;
        //}
	}
}
