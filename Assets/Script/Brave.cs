using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;
	[SerializeField] GameObject fade;

	public GameObject ExploadObj;
	public GameObject ExploadPos;
	Fade _fade;
	bool bom = true;

	// Use this for initialization
	void Start ( ) {
		_fade = fade.gameObject.GetComponent<Fade> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay( Collision collision ) {
		if (collision.gameObject.name == "boss") {
			if (bom) {
				Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
				bom = false;
			}
			StartCoroutine (FadeDelay(3.0f, _fade.fadeStart));
			StartCoroutine (SceneLoad (4.0f, nextStage));
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
