﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushStart() {
		SceneManager.LoadScene ("Game");
	}

	public void PushBack() {

	}

	public void PushOption() {

	}
}
