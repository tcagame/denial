using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlLogo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3( 0.05f , 0.0f , 0.0f );
		if ( transform.position.x >= 0.85f  ) {
			transform.position = new Vector3(  0.85f, transform.position.y, transform.position.z );
		}
	}
}
