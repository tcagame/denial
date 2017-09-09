using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	[SerializeField] GameObject result;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			result.SetActive (true);
		}
	}
}
