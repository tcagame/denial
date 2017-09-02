using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelconTest : MonoBehaviour {
	private GameObject brave;
	private Vector3 m_mouseDownPosition;
	bool click; 
	bool Right;

	void Start ( ) {
		m_mouseDownPosition = transform.position;
		click = true;
		Right = true;
		brave = GameObject.Find( "Brave" );
		Debug.Log (brave);
	}

	void Update( ) {
		if ( click ) {
			if ( Input.GetMouseButtonUp ( 0 ) ) {
				click = false;
			} else {
				Vector3 inputPosition = new Vector3 ( Input.mousePosition.x, Input.mousePosition.y, 9.5f );
				Vector3 mousePos = Camera.main.ScreenToWorldPoint ( inputPosition );
				Vector3 mediumPos = ( mousePos - m_mouseDownPosition ) / 2.0f + m_mouseDownPosition;
				float dist = Vector3.Distance ( mousePos, m_mouseDownPosition );

				transform.position = mediumPos;
				transform.localScale = new Vector3 ( 1.0f, 1.0f, dist );
				transform.LookAt ( mousePos );
			}
		}
	}
	void OnMouseDown( ) {
		if ( Right ) {
			Right = false;
		} else {
			Right = true;
		}
	}

	void OnCollisionStay2D( Collision2D collision ) {
		Debug.Log ("oaoao");
		if ( Right ) {
			Vector2 left = new Vector2 ( brave.transform.position.x + 0.05f, brave.transform.position.y );
			brave.transform.position = left;
		} else {
			Vector2 right = new Vector2 ( brave.transform.position.x - 0.05f, brave.transform.position.y );
			brave.transform.position = right;
		}	
	}
}
