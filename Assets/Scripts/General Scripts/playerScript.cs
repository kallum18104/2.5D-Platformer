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
    public float cooldowntime = 1;
    private float nextDashTime = 0;

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //the player can't move the mouse.
        float horizontalInput = Input.GetAxis("Horizontal"); //the float horizontalinput is set to the horizontal axis.
        rb = GetComponent<Rigidbody>(); //rb variable is set to the RigidBody component on any set object.
        jump = new Vector3(0.0f, 2.0f, 0.0f); //the jump is set to a vector3 force.
        leftDash = new Vector3(-2.0f, 0.0f, 0.0f); //the left dash is set to a vector3 force
        rightDash = new Vector3(2.0f, 0.0f, 0.0f); //the right dash is set to a vector3 force

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true; //when colliding with anything, isGrounded is set to true.
    }

    void Update()
    { 

        float horizontalInput = Input.GetAxis("Horizontal") + Input.GetAxis("Horizontal_Keyboard"); //Horizontal and Horizontal_Keyboard means that for this it supports controller AND keyboard. Nothing else supports controller.




        var currentspd = movespeed * Time.deltaTime * (1);

        transform.Translate(horizontalInput * currentspd, 0,0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse); //if you press space and you are grounded, it addes the jump Vector3, multiplied by the jumpForce float.
            isGrounded = false; //sets isGrounded to false
        }  

        if (Time.time > nextDashTime) //if the time has progressed over the dash cooldown time, it will let you dash.
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                rb.AddForce(rightDash * dashForce, ForceMode.Impulse); //if you press E, it adds the rightDash Vector3, multiplied by the dashForce
                CameraShake.shakeDuration = 0.1f; //references the CameraShake script and sets the shakeDuration to 0.1f
                nextDashTime = Time.time + cooldowntime; //sets the dash cooldown back up to 1 second.
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {

                //does the same as the last but in the opposite direction
                rb.AddForce(leftDash * dashForce, ForceMode.Impulse);
                CameraShake.shakeDuration = 0.1f;
                nextDashTime = Time.time + cooldowntime;

            }
        }

       

        if (rotateCube.isRotated)
        {
            //sets it so that if the player is rotated, you dash on the z axis so it still works.
            leftDash = new Vector3(0.0f, 0.0f, 2.0f);
            rightDash = new Vector3(0.0f, 0.0f, -2.0f);
        }
        else
        {
            //sets it back to normal when no longer rotated.
            leftDash = new Vector3(-2.0f, 0.0f, 0.0f);
            rightDash = new Vector3(2.0f, 0.0f, 0.0f);
        }

      
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }



}
