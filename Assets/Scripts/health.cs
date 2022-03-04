using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int playerHealth;
}

public class uniStats : health
{
    void Start()
    {
        playerHealth = 100;
    }
}