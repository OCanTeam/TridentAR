//====================================
//         Catcher.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/25
//====================================
using UnityEngine;

public class Catcher : MonoBehaviour {

    [SerializeField]
    private GameObject fishPrefab;

    public Camera _ARCamera;

    private Quest _quest;

    private bool barDone;


    private void Start()
    {
        _quest = gameObject.GetComponent<Quest>();
    }
    void Update()
    {
        //Get info bar
        barDone = gameObject.GetComponent<ProgressBar>().CatchFlag;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _ARCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (barDone)
                {
                    //Destroy Fish Object if clicked while bar done
                    Destroy(fishPrefab);
                    //Quest cleared
                    _quest.isGameClear(true);
                      
                }

            }
        }
        ////When clicked
        //for (int i = 0; i < Input.touchCount; ++i)
        //{
        //    if (Input.GetTouch(i).phase == TouchPhase.Began)
        //    {
        //        if (barDone)
        //        {
        //            //Destroy Fish Object if clicked while bar done
        //            Destroy(fishPrefab);
        //            //Quest cleared
        //            _quest.clear = true;
        //        }
        //    }
        //}
    }
}
