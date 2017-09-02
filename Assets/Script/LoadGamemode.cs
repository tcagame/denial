using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGamemode : MonoBehaviour {

	public void PushButtonStart() {
		SceneManager.LoadScene ("Game");
	}
}
