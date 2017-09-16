using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
	[SerializeField] float count;
	private float countDown;
	[SerializeField] Text timeText;
	[SerializeField] GameObject player;


	// Use this for initialization
	void Start () {
		countDown = count;
	}
	
	// Update is called once per frame
	void Update () {
		countDown -= Time.deltaTime;
		countDown = Mathf.Max (countDown, 0, 0);
		timeText.text = ((int)countDown - 1).ToString();
		if (((int)countDown) == (count - 1f)) {
			player.SetActive (false);
		}

		if (((int)countDown) == 1) {
			timeText.text = "START";
		}

		if (((int)countDown) <= 0) {
			player.SetActive (true);
			this.gameObject.SetActive (false);
		}

		/*if (Input.GetMouseButtonDown (0)) {
			player.SetActive (true);
			this.gameObject.SetActive (false);
		}*/
	}
}
