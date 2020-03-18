using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolanRotate : MonoBehaviour {

 

	// Use this for initialization
    void Start()
    {
		
	}
    public float rotate;
    float turn;


	// Update is called once per frame
    void Update()
    {
        turn = Input.GetAxis("Horizontal") * rotate * Time.deltaTime;
        transform.Rotate(0f, turn, 0f, Space.Self);

        //transform.Rotate(-turn, 0f, 0f);
      //  transform.localEulerAngles = new Vector3(-turn-360, 0, 0);
        
	}
     
}
