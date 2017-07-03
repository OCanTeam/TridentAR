//====================================
//         FloorManager.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/18
//====================================
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    private GameManager _gm;
    private int _maxQuest;

    public GameObject[] floorButtons;

	// Use this for initialization
	void Start ()
    {
        _gm = GameManager.instance;

        //foreach(var go in floorButtons)
        //{
        //    _maxQuest += go.GetComponent<FloorButton>().questListNum;
        //}

	}
	
}
