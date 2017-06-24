using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move2d : MonoBehaviour
{

    void Start()
    {

    }
    void Update()
    {
        var body = GetComponent<Rigidbody>();
        body.constraints = RigidbodyConstraints.FreezeRotation |
                           RigidbodyConstraints.FreezePositionZ;             
    }
}
