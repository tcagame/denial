using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay( Collision collision ) {
		if (collision.gameObject.name == "boss") {
			SceneManager.LoadScene ("nextStage");
		}
		if (collision.gameObject.name == "boss2") {
			SceneManager.LoadScene ("StuffedRoll");
		}
	}
}
