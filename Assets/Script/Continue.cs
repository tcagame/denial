using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continue : MonoBehaviour {
	
	string scenename;
	SceneTest _sceneTest;
	//[SerializeField] GameObject target;

	void Start () {
		_sceneTest = GameObject.Find ("nowScene").GetComponent<SceneTest> ();
		scenename = _sceneTest.scenename;
		Debug.Log (scenename);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void pushContinue() {
		SceneManager.LoadScene (scenename);
	}

	public void pushTitle () {
		SceneManager.LoadScene ("Title");
	}
}
