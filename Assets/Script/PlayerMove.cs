using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private float m_movePower = 1500.0f;

    private Vector3 m_prevVelocity = Vector3.zero;

    void Update()
    {
        var body = GetComponent<Rigidbody>();

        body.AddForce(-m_prevVelocity);

        var velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += Vector3.left;
        }

        velocity *= m_movePower;
        body.AddForce(velocity);

        m_prevVelocity = velocity;
    }
}