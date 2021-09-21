using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]//va arata in inspector variabila chiar de ii private
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        //Calculate movement velocity as a 3D vector
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHorizontal = transform.right * xMov;
        Vector3 movVertical = transform.forward * zMov;

        //final movement vector
        Vector3 velocity = (movHorizontal + movVertical).normalized * speed;

        //Apply moevement 
        motor.Move(velocity);

        //Calculate rotation as a 3dVector (turning around)

        float yRotat = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0f, yRotat, 0f) * lookSensitivity;

        //apply rotation

        motor.Rotate(rotation);

        //Calculate camera rotation as a 3dVector (turning around)

        float xRotat = Input.GetAxisRaw("Mouse Y");

        Vector3 cameraRotation = new Vector3(xRotat, 0f, 0f) * lookSensitivity;

        //apply caemra rotation

        motor.RotateCamera(cameraRotation);
    }


}
