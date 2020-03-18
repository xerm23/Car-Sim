using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour {

 

	// Use this for initialization
    void Start()
    {
		
	}
    public float movespeed;
    public float rotatespeed;
    float turnaround;


	// Update is called once per frame
    void Update()
    {
       // distToGround = cd.bounds.extents.y;
        turnaround = Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;
       
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * Time.deltaTime * movespeed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.forward * Time.deltaTime * movespeed;
                turnaround *= -1;
            }
            transform.Rotate(0f, turnaround, 0f);
        
	}
     
}
