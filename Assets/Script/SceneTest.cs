﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour {

	public string scenename;
	Brave _brave;
	string nowSceneName;
	private static bool _isCreate;

	void Awake () {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	// Use this for initialization
	void Start () {
		if (nowSceneName != "Gameover") {
			if (!_isCreate) {
				DontDestroyOnLoad (this.gameObject);
				scenename = SceneManager.GetActiveScene ().name;
				_isCreate = true;
			} else if ( _isCreate ) {
				Destroy (this.gameObject);

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		/*if ( SceneManager.activeSceneChanged ) {
			scenename = SceneManager.GetActiveScene ().name;
		}*/
	}
	private void OnSceneLoaded( Scene scene, LoadSceneMode mode ) {
		nowSceneName = SceneManager.GetActiveScene ().name;
		if (nowSceneName != "Gameover") {
			scenename = SceneManager.GetActiveScene ().name;
		}
	}
}
