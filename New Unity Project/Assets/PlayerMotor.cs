using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMotor : MonoBehaviour
{
    private Vector3 _velocity = Vector3.zero;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //Gets a moevemnt vector
    public void Move(Vector3 velocity)
    {
        _velocity = velocity;  
    }

    //Run every physics iteration
    void FixedUpdate()
    {
        PerformMovement();  
    }

    //Perform movement based on velocity variable
    void PerformMovement ()
    {
        if (_velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + _velocity * Time.fixedDeltaTime);
        }
    }

}
