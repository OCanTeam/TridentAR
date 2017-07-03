//====================================
//         SelectPatora.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/18
//====================================
using UnityEngine;

public class SelectPatora : MonoBehaviour {

    [HideInInspector] public int _currentFloor;

    private GameManager _gm;

    // Use this for initialization
    void Start () {
        _gm = GameManager.instance;		
	}
	
}
