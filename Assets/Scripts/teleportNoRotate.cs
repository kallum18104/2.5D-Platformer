using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportNoRotate : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public Rigidbody plyr;

    private void OnTriggerEnter(Collider collider)
    {
        //when the player collides with this object, it takes the players position and puts it where the teleportTarget empty gameobject is.
        thePlayer.transform.position = teleportTarget.transform.position;
        plyr.velocity = Vector3.zero;
        plyr.angularVelocity = Vector3.zero;
    }
}
