using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	[SerializeField] GameObject result;
	[SerializeField] GameObject BGM;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			BGM.SetActive (false);
			result.SetActive (true);
		}
	}
}
