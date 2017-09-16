using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;
	[SerializeField] GameObject fade;
	[SerializeField] GameObject boss;

	public GameObject ExploadObj;
	public GameObject ExploadPos;
	public GameObject FireObj;
	public GameObject FirePos;

	Fade _fade;
	bool bom = true;

	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start ( ) {
		_fade = fade.gameObject.GetComponent<Fade> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!bom) {
			StartCoroutine (FadeDelay(1.0f, _fade.fadeStart));
			StartCoroutine (SceneLoad (4.0f, nextStage));
		}
	}

	void OnCollisionStay( Collision collision ) {
		if (collision.gameObject.name == "boss") {
			audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.Play();
			if (bom) {
				Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
				Instantiate (FireObj, FirePos.transform.position, Quaternion.identity);
				bom = false;
				transform.position = new Vector3 (transform.position.x, transform.position.y, 100.0f);
				boss.gameObject.SetActive (false);
			}
			StartCoroutine (FadeDelay(1.0f, _fade.fadeStart));
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
