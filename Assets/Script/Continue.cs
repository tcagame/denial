using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continue : MonoBehaviour {
	string scenename;
	[SerializeField] GameObject target;

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
		SceneManager.LoadScene ("Menu");
	}

	public void ContinueActive() {
		this.gameObject.SetActive (false);
		target.SetActive (true);
	}
}
