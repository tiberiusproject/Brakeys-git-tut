using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    //every fixed update spawns a cube
    void FixedUpdate()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity); 
    }
}
