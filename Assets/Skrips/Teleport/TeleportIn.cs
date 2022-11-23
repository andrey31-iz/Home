using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIn : MonoBehaviour
{
    [SerializeField] private Transform _teleportIn;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Graund")
        {
            collision.transform.position = _teleportIn.position;
        }
    }
}
