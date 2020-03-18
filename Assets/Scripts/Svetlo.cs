using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svetlo : MonoBehaviour {
    public GameObject svetlo1;
    public GameObject svetlo2;

    Vector3 endPositionu;
    Vector3 endPositiond;

	// Use this for initialization
	void Start () {
        svetlo1.SetActive(false);
        svetlo2.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            promena();
        }
		
	}
    public void promena()
    {
        endPositionu = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        endPositiond = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);

        if (!svetlo1.activeSelf)
            transform.position = endPositiond;
        else
            transform.position = endPositionu;

        svetlo1.SetActive(!svetlo1.activeSelf);
        svetlo2.SetActive(!svetlo2.activeSelf);
    }
}
