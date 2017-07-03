//====================================
//         GameManager.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/25
//====================================
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public enum PatoraType
    {
        None,

        Game,
        CG,
        Web,
        IT,
        CAD,
    }
    public struct Patora
    {
        PatoraType type;
        int maxQuest;
    }
    
    private int _trai;
    private int _questNo;
    private PatoraType _patoraInfo;


    private void Awake()
    {
        //Singleton pattern 
        if (!instance)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }
    // Use this for initialization
    void Start ()
    {
        _patoraInfo = PatoraType.None;

     
    }

    private void Update()
    {
        Debug.Log("Patora Info = " + _patoraInfo);
        Debug.Log("Quest = " + _questNo);
        Debug.Log("Torai = " + _trai);
    }

    //-----------------------------------------------
    // Get and Set Quest
    //-----------------------------------------------
    public int Quest
    {
        get { return _questNo; }
        set { _questNo = value; }
    }

    //-----------------------------------------------
    // Get and Set Floor info
    //-----------------------------------------------
    public PatoraType CurrentPatora
    {
        get { return _patoraInfo; }
        set { _patoraInfo = value; }
    }

    //-----------------------------------------------
    // Get and Set Tri
    //-----------------------------------------------
    public int Trai
    {
        get { return _trai; }
        set { _trai += value; }
    }


}

