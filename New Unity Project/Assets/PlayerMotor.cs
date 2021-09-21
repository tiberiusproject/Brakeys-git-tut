using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMotor : MonoBehaviour
{
    [SerializeField]
    private Camera cam;


    private Vector3 _velocity = Vector3.zero;
    private Vector3 _rotation = Vector3.zero;
    private Vector3 _cameraRotation = Vector3.zero;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //Gets a moevemnt vector
    public void Move (Vector3 velocity)
    {
        _velocity = velocity;  
    }

    //Gets a rotation vector
    public void Rotate(Vector3 rotation)
    {
        _rotation = rotation;
    }

    //Gets a rotation vector for the camera 
    public void RotateCamera (Vector3 cameraRotation)
    {
        _cameraRotation = cameraRotation;
    }

    //Run every physics iteration
    void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }

    //Perform movement based on velocity variable
    void PerformMovement ()
    {
        if (_velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + _velocity * Time.fixedDeltaTime);
        }
    }

    //Perform Rotation 
    void PerformRotation ()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(_rotation));
        if (cam != null)
        {
            cam.transform.Rotate(-_cameraRotation);
        }
    }

}
