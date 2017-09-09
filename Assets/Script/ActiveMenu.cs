using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveMenu : MonoBehaviour {
	[SerializeField] GameObject start;
	[SerializeField] GameObject menu;

	public void PushStartbutton() {
		start.SetActive (false);
		menu.SetActive (true);
	}
}
