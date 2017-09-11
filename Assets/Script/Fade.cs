using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {
	private Image image;
	private Color alpha;
	private float startTime;
	public string fadeStart;
	//[SerializeField] string name;
	[SerializeField] private float fadeTime;

	// Use this for initialization
	void Start () {
		image = this.GetComponent<Image> ();
		startTime = Time.time;
		//fadeStart = "FadeIn";
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (image.color.a == 0) {
			SceneManager.LoadScene (name);
			startTime = Time.time;
			fadeStart = "FadeIn";
		}*/
	}

	public void FadeSwitch( string fadetype ) {
		switch (fadeStart) {
		case "fadein":
			alpha.a = 1.0f - (Time.time - startTime) / fadeTime;
			image.color = new Color (0, 0, 0, alpha.a);
			Debug.Log (image.color.a);
			break;
		case "fadeout":
			alpha.a = (Time.time - startTime) / fadeTime;
			image.color = new Color (0, 0, 0, alpha.a);
			Debug.Log (image.color.a);
			break;
		}
	}
		
}
