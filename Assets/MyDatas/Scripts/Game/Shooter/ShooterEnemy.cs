//====================================
//         ShooterEnemy.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/17
//====================================
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    public float _lifeTime = 5f;

    private void OnEnable()
    {
        Invoke("Destroy", _lifeTime);
    }
    void Destroy()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
