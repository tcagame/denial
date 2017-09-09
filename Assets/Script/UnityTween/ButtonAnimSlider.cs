using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimSlider : MonoBehaviour
{
	[SerializeField] private float _fromX;
	[SerializeField] private float _toX;
	[SerializeField] private float _time;
	[SerializeField] private bool _active = false;
	[SerializeField] private Button _target;
	

	/// <summary>
	/// Buttonクラス取得
	/// </summary>
	private void Awake()
	{
		_target = gameObject.GetComponent<Button>();
		
		
	}


	/// <summary>
	/// 初期値取得
	/// AddListener設定
	/// </summary>
	void Start () {
		
		if (_target != null)
		{

		}
		else
		{
			Destroy(this);
		}
		
		_target.onClick.AddListener (() =>
		{
			if (_active)
			{
//				TweenScale.Tween(gameObject, 1.0f, )

				_active = false;
			}
			else
			{
//				TweenScale.Tween(gameObject, 1.0f, )
				_active = true;
			}
			
		});
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
