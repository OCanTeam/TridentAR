using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {

    public int trai;
    private bool _clear = false;

    [SerializeField]
    private QuestManager _qm;
    private GameManager _gm;

	// Use this for initialization
	void Start () {
        _gm = GameManager.instance;	
	}

    public void isGameClear(bool clear)
    {
        _clear = clear;

        if (clear)
        {
            clear = false;
            _gm.Trai = trai;
            _qm.clear = true;

        }
    }
}
