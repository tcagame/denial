using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffedRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3( 0.0f , 1.5f , 0.0f );
		if ( transform.position.y >= 1500.0f  ) {
			transform.position = new Vector3( transform.position.x , -51.0f, transform.position.z );
		}
	}
}
