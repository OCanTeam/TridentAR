//====================================
//         QuestManager.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/10
//====================================
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private GameManager _gm;         
    private int currentQuest;
    private int selectedFloor;
    public bool clear;

    [SerializeField]
    private GameObject _clearTextObj;
    [SerializeField]
    private GameObject[] _targetImages;

    // Use this for initialization
    void Start ()
    {
        //Get Instance from GameManager
        _gm = GameManager.instance;

        _clearTextObj.SetActive(false);
        clear = false;


        //Load active quest from GameManager
        LoadQuest(_gm.Quest);
        
	}
    //-----------------------------------------------
    // Check current quest clear or not
    //-----------------------------------------------
    public void isClear(bool flag)
    {
        clear = flag;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (clear)
        {
            clear = false;

            //for debug
            _clearTextObj.SetActive(true);

            //Set a new quest when finish the game
            _gm.Quest = currentQuest + 1; 
        }

    }
    //-----------------------------------------------
    // Load quest with giving quest number
    //-----------------------------------------------
    public void LoadQuest(int questNum)
    {
        currentQuest = questNum;

        //Deactived all quest except current quest
        for (int i = 0; i < _targetImages.Length; i++)
        {
            if (i != currentQuest - 1)
            {
                _targetImages[i].SetActive(false);
            }
        }
        
    }
}
