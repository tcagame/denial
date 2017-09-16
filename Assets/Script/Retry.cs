using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {
	string scenename;
	[SerializeField] GameObject se;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void ContinueYes() {
		scenename = SceneManager.GetActiveScene().name;
		StartCoroutine (DelaySE());

	}

	public void ContinueNo() {
		
		StartCoroutine (DelaySETitle());
	}

	public void PlaySE_touch () {
		se.SetActive(true);
	}

	IEnumerator DelaySE() {
		PlaySE_touch ();
		Debug.Log ("a");
		yield return new WaitForSeconds (1.5f);

		SceneManager.LoadScene (scenename);
	}

	IEnumerator DelaySETitle() {
		PlaySE_touch ();

		yield return new WaitForSeconds (1.5f);

		SceneManager.LoadScene ("Title");
	}
}
