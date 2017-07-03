//====================================
//         SceneScript.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/25
//====================================
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {


    [SerializeField]
    private bool _transWithFade = false;
    [SerializeField]
    private ScreenOrientation orientation = ScreenOrientation.AutoRotation;
    [SerializeField]
    private string _loadSceneName;

    private GameManager _gm;
    //private int _sceneNum;

    private void Awake()
    {
        Screen.orientation = orientation;
        
    }
    //-----------------------------------------------
    // Change scene with giving the number of scene
    // param : scene number
    //-----------------------------------------------
    public void Change(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void ChangeWithFade(string scene, float interval)
    {
        Fade.instance.LoadScene(scene, interval);
    }


    private void Start()
    {
        _gm = GameManager.instance;

        
        //if(SceneManager.GetActiveScene().name != "AR")
        //{
        //    Screen.orientation = ScreenOrientation.Portrait;
        //}
        //else
        //{
        //    Screen.orientation = ScreenOrientation.Landscape;
        //}

        if(_transWithFade)
        {
            Fade.instance.LoadScene(_loadSceneName, 3);
        }
    }

    public void ChangeSceneWithPatora()
    {
        switch (_gm.CurrentPatora)
        {
            case GameManager.PatoraType.Game:
                SceneManager.LoadScene("AR");
                break;
            case GameManager.PatoraType.CG:
                SceneManager.LoadScene("CG");
                break;
            case GameManager.PatoraType.Web:
                SceneManager.LoadScene("Web");
                break;
            case GameManager.PatoraType.IT:
                SceneManager.LoadScene("IT");
                break;
            case GameManager.PatoraType.CAD:
                SceneManager.LoadScene("CAD");
                break;
            case GameManager.PatoraType.None:
                //SceneManager.LoadScene("PatoraAR");
                break;
        }

    }
}
