using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private float movespeed = 4.0f;
    public Vector3 jump;
    public float jumpForce = 3f;
    public float dashForce = 3f;
    public bool isGrounded;
    public Vector3 rightDash;
    public Vector3 leftDash;

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        float horizontalInput = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        leftDash = new Vector3(-2.0f, 0.0f, 0.0f);
        rightDash = new Vector3(2.0f, 0.0f, 0.0f);

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    void Update()
    { 

        float horizontalInput = Input.GetAxis("Horizontal") + Input.GetAxis("Horizontal_Keyboard");
        
     
       

        var currentspd = movespeed * Time.deltaTime * (1);

        transform.Translate(horizontalInput * currentspd, 0,0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }  

        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(rightDash * dashForce, ForceMode.Impulse);
            CameraShake.shakeDuration = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddForce(leftDash * dashForce, ForceMode.Impulse);
            CameraShake.shakeDuration = 0.2f;
        }

        if (rotateCube.isRotated)
        {
            leftDash = new Vector3(0.0f, 0.0f, 2.0f);
            rightDash = new Vector3(0.0f, 0.0f, -2.0f);
        }
        else
        {
            leftDash = new Vector3(-2.0f, 0.0f, 0.0f);
            rightDash = new Vector3(2.0f, 0.0f, 0.0f);
        }

      
    }

    
}
