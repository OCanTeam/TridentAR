using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Fade : MonoBehaviour {

    public static Fade instance = null;

    private float _fadeAlpha = 0;
    private bool _isFading = false;
    public Color _fadeColor = Color.black;
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

    private void OnGUI()
    {
        if(_isFading)
        {
            _fadeColor.a = _fadeAlpha;
            GUI.color = _fadeColor;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.whiteTexture);
        }
    }

    public void LoadScene(string scene, float interval)
    {
        StartCoroutine(TransFadeScene(scene, interval));
    }

    private IEnumerator TransFadeScene(string scene, float interval)
    {
        //だんだん暗く .
        _isFading = true;
        float time = -1f;
        while (time <= interval)
        {
            _fadeAlpha = Mathf.Lerp(0f, 1f, time / interval);
            time += Time.deltaTime;
            yield return 0;
        }

        //シーン切替 .
        SceneManager.LoadScene(scene);

        //だんだん明るく .
        time = 0;
        while (time <= interval)
        {
            _fadeAlpha = Mathf.Lerp(1f, 0f, time / interval);
            time += Time.deltaTime;
            yield return 0;
        }

        _isFading = false;
    }

}
