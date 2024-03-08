using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }

        //Lift
        Vector3 lift = Vector3.Project(rb.velocity,transform.forward);
        rb.AddForce(transform.up*lift.magnitude*liftBooster);
    }
}//lift
