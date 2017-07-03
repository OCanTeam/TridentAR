using UnityEngine;

public class CoverRotate : MonoBehaviour
{
    [SerializeField]
    private float angle = 0.05f;

	void Update ()
    {
        transform.Rotate(0,0,angle);
	}
}
