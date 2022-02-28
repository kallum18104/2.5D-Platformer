using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{

    static public bool isRotated;
    public GameObject player;
    public Rigidbody plyr;

    void Start()
    {
        //player isn't rotated at initial spawn
        isRotated = false;
    }

    void OnCollisionEnter(Collision collision)
    {
       //when they collide with a rotation point, this is executed if they aren't already rotated.
        if (isRotated == false)
        {
            //rotates the player by 90 degrees and sets the isRotated bool to be true.
            player.transform.Rotate(0, 90, 0, Space.World);
            isRotated = true;
            plyr.velocity = Vector3.zero;
            plyr.angularVelocity = Vector3.zero;
        }

        
    }
}
