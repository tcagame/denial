using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyor : MonoBehaviour
{

    private float movePower = 1000.0f;
    public static bool changeOfDirection = true;

    void OnCollisionEnter(Collision other)
    { 
        var body = other.gameObject.GetComponent<Rigidbody>();

        if (changeOfDirection == true)
        {
            body.velocity = Vector3.zero;
            Vector3 addPower = transform.right * movePower;
            body.AddForce(addPower, ForceMode.Acceleration);
        }
        else if(changeOfDirection == false) 
        {
            body.velocity = Vector3.zero;
            Vector3 addPower = -transform.right * movePower;
            body.AddForce(addPower, ForceMode.Acceleration);
        }
    }
    void OnCollisionExit(Collision other)
    {
        var body = other.gameObject.GetComponent<Rigidbody>();
        body.velocity = Vector3.zero;
        //ver1
        //Vector3 addPower = -transform.right * movePower;
        //body.AddForce(addPower, ForceMode.Acceleration);
        //ver2
        //body.AddForce(Vector3.zero, ForceMode.Acceleration);
        //Invoke("DelayMethod", 1f);
        //ver3
        //body.velocity = Vector3.zero;
        //ver4
        //StartCoroutine("DelayMethod",body );
    }
    //vet4
    /*IEnumerator DelayMethod(Collision other )
    {
        yield return new WaitForSeconds(1);
        var body = other.gameObject.GetComponent<Rigidbody>();
        body.AddForce(Vector3.zero, ForceMode.Acceleration);
    }*/
    /* ver2
    void DelayMethod(Collision other)
    {
        var body = other.gameObject.GetComponent<Rigidbody>();
        Vector3 addPower = -transform.right * movePower;
        body.AddForce(addPower, ForceMode.Acceleration);
    }
    */
}
