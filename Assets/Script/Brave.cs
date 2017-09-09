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
<<<<<<< HEAD
			SceneManager.LoadScene ("nextStage");
=======
			SceneManager.LoadScene ("Title");
>>>>>>> 9bb22a178ba3839407513d64fda387db1489e3f4
		}
		if (collision.gameObject.name == "boss2") {
			SceneManager.LoadScene ("StuffedRoll");
		}
	}
}
