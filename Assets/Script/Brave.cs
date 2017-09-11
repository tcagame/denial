using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;
	[SerializeField] GameObject fade;

<<<<<<< HEAD
	public GameObject ExploadObj;
	public GameObject ExploadPos;
=======
	Fade _fade;
>>>>>>> 709c0354b453595410290436fb52904eff8622ea

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
			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
			fade.gameObject.SetActive (true);
			StartCoroutine (SceneLoad (1.5f, nextStage));
=======
			StartCoroutine (FadeDelay(1.5f, _fade.fadeStart));
			StartCoroutine (SceneLoad (2.5f, nextStage));
>>>>>>> 709c0354b453595410290436fb52904eff8622ea
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
