//====================================
//         ImageManager.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/26
//====================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour {

    [SerializeField] private GameObject _targetObject;
    [SerializeField] private Texture[] _textures;
    [SerializeField] private Text _triText;
    [SerializeField] private Texture _defaultTexture;
    private Renderer _rend;
    private GameManager _gm;

    // Use this for initialization
    void Start()
    {
        _gm = GameManager.instance;
      
        _rend = _targetObject.gameObject.GetComponent<Renderer>();

        if (_gm.Quest != 0)
        {
            _rend.material.mainTexture = _textures[_gm.Quest];
        }

        //Render image texture with current quest
        _rend.material.mainTexture = _defaultTexture;
        _triText.text = _gm.Trai.ToString();
    }
    

}
