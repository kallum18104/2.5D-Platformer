using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider collider)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        if (rotateCube.isRotated)
        {
            thePlayer.transform.Rotate(0, 270, 0, Space.World);
            rotateCube.isRotated = false;
        }
    }
}
