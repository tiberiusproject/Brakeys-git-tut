using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IPooledObject
{
    public float upForce = .5f;
    public float sideForce = .3f;

    //use this for initialization
    public void OnObjectSpawn ()
    {
        //calculates a random force
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 0.1f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        //adds the random force to the rgb
        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }
}
