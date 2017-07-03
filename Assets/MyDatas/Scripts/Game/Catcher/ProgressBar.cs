//====================================
//         ProgressBar.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/25
//====================================
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	public Camera ARCamera;
    public GameObject RadialProgressBarLeft;       
	public Transform LoadingBarLeft;
	public GameObject CatchImg;
    public bool CatchFlag = false;

    [SerializeField] private float currentAmount;
	[SerializeField] private float speed = 10;

	void Update ()
    {
        //get ray from camera through a screen point 
        Ray ray = ARCamera.ScreenPointToRay(RadialProgressBarLeft.transform.position);
        RaycastHit hit;

        //When hit
        if (Physics.Raycast(ray, out hit, 10000000000000000000.0f)){
            currentAmount += speed * Time.deltaTime;
        }
        else{
            currentAmount -= speed / 1.5f * Time.deltaTime;
        }
        if(currentAmount <= 0){
            currentAmount = 0;
        }else if (currentAmount >= 100){
            currentAmount = 100;
        }

        //Calculate amount
        LoadingBarLeft.GetComponent<Image>().fillAmount = currentAmount / 100;

        //Change LoadBar Color
        if (currentAmount >= 100){
            LoadingBarLeft.GetComponent<Image>().color = new Color(0, 1, 0, 0.5f);
        }else{
            LoadingBarLeft.GetComponent<Image>().color = new Color(1, 0, 0, 0.5f);
        }
        //If bar full, show img
        if (LoadingBarLeft.GetComponent<Image>().fillAmount >= 1){
            CatchImg.SetActive(true);
            CatchFlag = true;
        }else{
            CatchImg.SetActive(false);
            CatchFlag = false;
        }
    }


}
