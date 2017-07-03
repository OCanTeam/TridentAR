//====================================
//         Shooter.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/05/15
//====================================
using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject arCameraPos;
    [SerializeField]
    private float speed = 5;

    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //Shot
                Fire();
            }
        }

    }


    public void Fire()
    {
        GameObject bullet = null;
        bullet = Instantiate(bulletPrefab, arCameraPos.transform.position, arCameraPos.transform.rotation);
        if (bullet)
            bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * speed);
    }
}
