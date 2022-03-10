using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int playerHealth;
    //decalres an int of playerhealth
}

public class uniStats : health
{
    void Start()
    {
        playerHealth = 100;
        //sets the int to 100. This script will be used in others.
    }
}