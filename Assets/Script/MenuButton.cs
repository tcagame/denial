using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	[SerializeField] string sceneName;
	[SerializeField] GameObject se;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushStart() {
		
		StartCoroutine (DelaySE());

	}

	public void PushBack() {

	}

	public void PushOption() {

	}
	public void PlaySE_touch () {
		se.SetActive(true);
	}

	IEnumerator DelaySE() {
		PlaySE_touch ();
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (sceneName);
	}
}
