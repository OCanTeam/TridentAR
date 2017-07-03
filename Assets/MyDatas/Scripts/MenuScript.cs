using UnityEngine;

public class MenuScript : MonoBehaviour {

    [SerializeField]
    private GameManager.PatoraType _thisCourse = GameManager.PatoraType.None;
    [SerializeField]
    private Texture[] _textures;
    [SerializeField]
    private GameObject _imageQuest;

    public int currentQuest;

    private int _questMaxNum;

    private GameManager _gm;   

    private Renderer _rend;

    private void Awake()
    {
        _gm = GameManager.instance;

        if (_gm)
        {
            if (_thisCourse != _gm.CurrentPatora)
            {
                gameObject.SetActive(false);
            }          
        }
    
    }

    // Use this for initialization
    void Start () {

        _questMaxNum = _textures.Length;

        if (_gm)
        {
            if (currentQuest < _gm.Quest)
            {
                currentQuest = _gm.Quest;
            }

            _rend = _imageQuest.gameObject.GetComponent<Renderer>();
            _rend.material.mainTexture = _textures[currentQuest - 1];
        }
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(gameObject.name + "  =  " + currentQuest);
    }
}