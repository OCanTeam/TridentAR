//====================================
//         Patora.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/26
//====================================
using UnityEngine;

public class Patora : MonoBehaviour {

    [SerializeField]
    private Camera _ARCamera;

    [SerializeField]
    private GameManager.PatoraType _course;

    private GameManager _gm;

	// Use this for initialization
	void Start () {
        _gm = GameManager.instance;

	}
	
	// Update is called once per frame
	void Update () {

        //When touched
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _ARCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    if(_gm.CurrentPatora != _course)
                    {
                        _gm.Quest = 1;
                    }
                    //if (_gm.Quest <= 1 && _gm.CurrentPatora != _course)
                    //{
                    //    _gm.Quest = 1;
                    //}
                    //Set selected patora into game manager 
                    _gm.CurrentPatora = _course;

                    
                }

            }
        }
    }
}
