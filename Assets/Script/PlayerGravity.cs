using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour {

    
    void OnCollisionEnter(Collision other)
    {
        Physics.gravity = new Vector3( 0, 0, 0);
    }
    void OnCollisionExit(Collision other)
    {

        Physics.gravity = new Vector3(0, -9.81f, 0);

    }
}
