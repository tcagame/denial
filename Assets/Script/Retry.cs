using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {
	string scenename;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ContinueYes() {
		scenename = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene (scenename);
	}

	public void ContinueNo() {
		SceneManager.LoadScene ("Title");
	}
		
}
