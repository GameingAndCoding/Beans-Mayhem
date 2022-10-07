using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    
    public int PlayerNumber;
	public TurnSwitch TurnSwitch;

	// for jumping
    public Transform groundCheck;
    public bool isGrounded = true;
    public LayerMask groundMask;
    public float groundDistance = 1f;
	public Rigidbody rb;
    

	//moving relative to this
    public Camera Camera;


    public float limit , Counter;

    void FixedUpdate()
    {

        if(TurnSwitch.CurrentPlayer == PlayerNumber)
        {

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (Input.GetKeyDown("space") && isGrounded == true)
            {
                jump();
            }


            //movement input
            float xInput = Input.GetAxis("Horizontal");
            float zInput = Input.GetAxis("Vertical");


            //camera forward and right vectors:
            Vector3 forward = Camera.transform.forward;
            Vector3 right = Camera.transform.right;

            //project forward and right vectors
            Vector3 FRelative = zInput * forward;
            Vector3 RRelative = xInput * right;

            //direction in the world space 
            Vector3 cameraRelativeMovement = FRelative + RRelative;

            //movement
            if (Counter < limit)
            {
                this.transform.Translate(cameraRelativeMovement /10, Space.World);
            }
			
			//limiting movement
            if(zInput!=0 || xInput!=0)
            {
                Counter += 0.1f;

            }
         
   
        }


	 void jump(){
				rb.AddForce(0, 400, 0);
                isGrounded = false;
				}
    }



}