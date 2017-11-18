using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTest : MonoBehaviour {

	string scenename;
	Brave _brave;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		_brave = GameObject.Find("Brave").GetComponent<Brave> ();
		//GameObject _brave = GetComponent<Brave> ();
		scenename = _brave.getReTryScene();
		Debug.Log (scenename);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
