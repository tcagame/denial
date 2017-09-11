using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;
	[SerializeField] GameObject fade;

	Fade _fade;

	// Use this for initialization
	void Start ( ) {
		_fade = fade.gameObject.GetComponent<Fade> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay( Collision collision ) {
		if (collision.gameObject.name == "boss") {
<<<<<<< HEAD

            SceneManager.LoadScene (nextStage);
=======
			fade.gameObject.SetActive (true);
<<<<<<< HEAD
			StartCoroutine (FadeDelay(1.5f, _fade.fadeStart));
			StartCoroutine (SceneLoad (2.5f, nextStage));
=======
			StartCoroutine (SceneLoad (1.5f, nextStage));
>>>>>>> 48e3077e8e6b550e4a22df6f49f6b762a4f55d70
>>>>>>> d419bb4c745a46f5442120f3deff035d70fd6c80
		}
		if (collision.gameObject.name == "boss2") {

            SceneManager.LoadScene ("StuffedRoll");
		}
	}

	private IEnumerator SceneLoad( float time, string name ) {
		yield return new WaitForSeconds (time);

		SceneManager.LoadScene (name);
	}

	private IEnumerator FadeDelay( float time, string fadetype ) {
		yield return new WaitForSeconds (time);

		_fade.FadeSwitch (fadetype);
	}
		
}
