using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBelcon : MonoBehaviour {
	private GameObject brave;

	// Use this for initialization
	void Start () {
		brave = GameObject.Find( "Brave" );
		Debug.Log (brave);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay( Collision collision ) {
		Vector2 left = new Vector2 ( brave.transform.position.x + 0.05f, brave.transform.position.y );
		brave.transform.position = left;
	}
}
