using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController2D))]
public class PlayerMovement : MonoBehaviour {

    public int runSpeed;

    private float horizontalMove;
    private bool jump = false;
    private bool croutch = false;
    private CharacterController2D controller;

	// Use this for initialization
	void Start () {
        controller = gameObject.GetComponent(typeof(CharacterController2D)) as CharacterController2D;


    }
	
	// Update is called once per frame
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //Debug.Log("Input: " + Input.GetAxisRaw("Horizontal"));
        if (Input.GetButtonDown("Jump")) {
            jump = true;
            
        }

        if (Input.GetButtonDown("Crouch")) {
            croutch = true;
        }
        else if (Input.GetButtonUp("Crouch")) {
            croutch = false;
        }

        

	}


    private void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, croutch, jump);
        jump = false;
    }
}
