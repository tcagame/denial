using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimSlider : MonoBehaviour
{
	[SerializeField] private bool _active = false;
	[SerializeField] private Button _target;
	TweenPos posTweem;


	/// <summary>
	/// Buttonクラス取得
	/// </summary>
	private void Awake ()
	{
		_target = gameObject.GetComponent<Button> ();
		posTweem = gameObject.GetComponent<TweenPos> ();
		
		
	}


	/// <summary>
	/// 初期値取得
	/// AddListener設定
	/// </summary>
	void Start ()
	{
		
		if (_target != null) {
		} else {
			Destroy (this);
		}

		_target.onClick.AddListener (() => {
			if (_active) {
				TweenPos.Tween (gameObject, 1.0f, posTweem.from);
				_active = false;
			} else {
				TweenPos.Tween (gameObject, 1.0f, posTweem.to);
				_active = true;
			}
			
		}
		);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
