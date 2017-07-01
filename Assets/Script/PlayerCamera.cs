using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
    
    private Transform target;
    
    void Start()
    {
        target = GameObject.Find( "yuusya" ).transform;
    }
    
    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}