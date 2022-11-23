using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _MovementSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            moveToDirectionWithSpeed(Vector3.right);
        else if (Input.GetKey(KeyCode.A))
            moveToDirectionWithSpeed(Vector3.left);
        if (Input.GetKey(KeyCode.W))
            moveToDirectionWithSpeed(Vector3.forward);
        else if (Input.GetKey(KeyCode.S))
            moveToDirectionWithSpeed(Vector3.back);
        if(Input.GetKey(KeyCode.Space))
            moveToDirectionWithSpeed(Vector3.up);
        else if (Input.GetKey(KeyCode.LeftControl))
            moveToDirectionWithSpeed(Vector3.down);

    }
    private void moveToDirectionWithSpeed(Vector3 direction)
    {
        float normalSpeed = _MovementSpeed * Time.deltaTime;
        transform.position += direction * normalSpeed;
    }
}
