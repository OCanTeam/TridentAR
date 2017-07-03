//====================================
//         WaypointMovement.cs
//  -------------------------------
//
//@! IRFAN FAHMI RAMADHAN
//@! 2017/04/26
//====================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

    public GameObject[] waypoints;
    public int num = 0;
    public float minDist = 1;
    public float speed;
	
	// Update is called once per frame
	void Update ()
    {
        //Get distance between object and nearest waypoint position
        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);

        
        if (dist > minDist)
        {
            //Move the target when get the nearest waypoint position
            Move();
        }
        else
        {
            //get rand waypoint num 
            num = Random.Range(0, waypoints.Length);
        }
    }
    //-----------------------------------------------
    // Move target into point
    //-----------------------------------------------
    void Move()
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
}
