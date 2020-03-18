using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kazaljka : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 0.3f;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(speed, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-speed, 0, 0, Space.Self);
        }
	}
}
