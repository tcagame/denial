using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belcon : MonoBehaviour {
	public GameObject yuusya;
	public bool Right = true;

	// Use this for initialization
	void Start () 
	{
		
	}
		
	// Update is called once per frame
	void Update ()
	{

	}
		
	void OnMouseDown() 
	{
		if (Right) {
			Right = false;
		} else {
			Right = true;
		}
	}

	void OnCollisionStay2D(Collision2D collision)
	{

		if (Right) {
			Vector2 left = new Vector2 (yuusya.transform.position.x + 0.05f, yuusya.transform.position.y);
			yuusya.transform.position = left;
		} else {
			Vector2 right = new Vector2 (yuusya.transform.position.x - 0.05f, yuusya.transform.position.y);
			yuusya.transform.position = right;
		}	
	}
}
