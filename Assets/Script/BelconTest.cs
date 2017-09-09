using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelconTest : MonoBehaviour {
	private GameObject brave;
	private Vector3 m_mouseDownPosition;
	bool click; 
	bool Right;
	const float DESTROY_TIME = 4.0f;
	float _time = 0f;

	void Start ( ) {
		m_mouseDownPosition = transform.position;
		click = true;
		brave = GameObject.Find( "Brave" );
		_time = 0;
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
		_time += Time.deltaTime;
		if( _time > DESTROY_TIME ) {
			Destroy( gameObject );
		}
	}
	void OnCollisionStay( Collision collision ) {
		Vector2 left = new Vector2 ( brave.transform.position.x + 0.07f, brave.transform.position.y );
		brave.transform.position = left;	
	}
}
