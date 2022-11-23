using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    void Start()
    {
        // A rotation 30 degrees around the y-axis
        Vector3 rotationVector = new Vector3(0, 30, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);
    }
}


