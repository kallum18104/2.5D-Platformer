using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider collider)
    {
       //when the player collides with this object, it takes the players position and puts it where the teleportTarget empty gameobject is.
        thePlayer.transform.position = teleportTarget.transform.position;
        if (rotateCube.isRotated)
        {
           //if the player has been rotated, it will rotate them back to the origin rotation and will set isRotated bool to false.
            
            thePlayer.transform.Rotate(0, 270, 0, Space.World);
            rotateCube.isRotated = false;
        }
    }
}
