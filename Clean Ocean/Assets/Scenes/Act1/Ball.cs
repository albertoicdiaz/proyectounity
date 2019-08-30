using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{

    // gravity constant
    public float g = 9.8f;

    void FixedUpdate()
    {
        // normalize axis
        var gravity = new Vector3(
            Input.acceleration.x,
            Input.acceleration.z,
            Input.acceleration.y
        ) * g*-1;

        GetComponent<Rigidbody>().AddForce(gravity, ForceMode.Acceleration);
    }

}