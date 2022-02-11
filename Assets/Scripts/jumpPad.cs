using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    public Vector3 leftJump;
    public float padForce = 3f;
    public Rigidbody rb;

    void Start()
    {
        leftJump = new Vector3(4.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        rb.AddForce(leftJump * padForce, ForceMode.Impulse);
        CameraShake.shakeDuration = 0.1f;
    }
}
