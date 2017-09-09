using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {
	private Image image;
	private Color alpha;
	private float startTime;
	private string fadeStart;
	[SerializeField] string name;
	[SerializeField] private float fadeTime;

	// Use this for initialization
	void Start () {
		image = this.GetComponent<Image> ();
		startTime = Time.time;
		fadeStart = "FadeIn";
	}
	
	// Update is called once per frame
	void Update () {
		switch (fadeStart) {
		case "FadeIn":
			alpha.a = 1.0f - (Time.time - startTime) / fadeTime;
			image.color = new Color (0, 0, 0, alpha.a);
			Debug.Log (image.color.a);
			break;
		case "FadeOut":
			alpha.a = (Time.time - startTime) / fadeTime;
			image.color = new Color (0, 0, 0, alpha.a);
			Debug.Log (image.color.a);
			break;
		}
		if (image.color.a == 0) {
			SceneManager.LoadScene (name);
			startTime = Time.time;
			fadeStart = "FadeIn";
		}
	}
		
}
