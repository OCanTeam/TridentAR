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

	// Use this for initialization
	void Start () {
        if(textFile)
        {
            textLines = textFile.text.Split('\n');
        }

        
        //if (endAtLine == 0)
        //{
        //    endAtLine = textLines.Length - 1;
        //}

        StartCoroutine(AutoType());
    }

    IEnumerator AutoType()
    {
        text.text = "";
        foreach (char letter in textLines[currentLine].ToCharArray())
        {
            text.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
        text.text = textLines[currentLine];

        StartCoroutine(ChangeParagraf());



    }

    IEnumerator ChangeParagraf()
    {
        currentLine = Random.Range(1, textLines.Length);
        yield return new WaitForSeconds(interval);
        StartCoroutine(AutoType());
    }
}
