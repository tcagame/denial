using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thanks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0.03f, 0.0f, 0.0f);
        if (transform.position.x >= 0f)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }
}
