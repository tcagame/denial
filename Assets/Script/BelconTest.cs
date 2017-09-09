using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelconTest : MonoBehaviour {
	private GameObject brave;
	private Vector3 m_mouseDownPosition;
	bool click; 
	bool over_obj;
	const float DESTROY_TIME = 8.0f;
	float _time = 0f;
	const int CLEATE_COUNT = 30;
	private int _count;
	void Start ( ) {
		m_mouseDownPosition = transform.position;
		click = true;
		over_obj = false;
		brave = GameObject.Find( "Brave" );
	}

	void Update( ) {
		if ( click ) {
			_count++;
			if ( Input.GetMouseButtonUp ( 0 ) || over_obj ) {
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
		over_obj = true;
		if ( collision.gameObject.tag == "Player" && !click ) {
			Vector2 left = new Vector2 (brave.transform.position.x + 0.05f, brave.transform.position.y);
			brave.transform.position = left;	
		}
	}
}
