using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMenu : MonoBehaviour {
	[SerializeField] GameObject start;
	[SerializeField] GameObject menu;
	[SerializeField] GameObject fade;

	public void PushStartbutton() {
		start.SetActive (false);
		menu.SetActive (true);
	}

	public void PushBackButton() {
		menu.SetActive (false);
		start.SetActive (true);
	}

	public void PushGamestart() {
		fade.SetActive (true);
	}
}
