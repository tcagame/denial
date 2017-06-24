using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        
        Vector2 direction = new Vector2(x, 0).normalized;
        
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}