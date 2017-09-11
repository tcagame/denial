using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brave : MonoBehaviour {
	[SerializeField] string nextStage;
	[SerializeField] GameObject fade;

	public GameObject ExploadObj;
	public GameObject ExploadPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay( Collision collision ) {
		if (collision.gameObject.name == "boss") {
			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
			fade.gameObject.SetActive (true);
			StartCoroutine (SceneLoad (1.5f, nextStage));
		}
		if (collision.gameObject.name == "boss2") {
			SceneManager.LoadScene ("StuffedRoll");
		}
	}

	private IEnumerator SceneLoad( float time, string name ) {
		yield return new WaitForSeconds (time);

		SceneManager.LoadScene (name);
	}
		
}
