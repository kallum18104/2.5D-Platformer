using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{

    public bool isRotated;
    public GameObject player;

    void Start()
    {
        isRotated = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (isRotated == false)
        {
            player.transform.Rotate(0, 90, 0, Space.World);
            isRotated = true;
        }

        
    }
}
