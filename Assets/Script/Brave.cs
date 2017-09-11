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
			StartCoroutine (FadeDelay(1.5f, _fade.fadeStart));
			StartCoroutine (SceneLoad (2.5f, nextStage));
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

		fade.gameObject.SetActive (true);
		_fade.FadeSwitch (fadetype);
	}
		
}
