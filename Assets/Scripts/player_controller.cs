using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

    // Other variables
    public float speed;

    // Physics variables
    private Rigidbody rb;

    // Movement direction variables
    float moveXDirection;
    float moveYDirection;
    float moveZDirection;

	// Use this for initialization
	void Start () {
        
        // Grab the rigidbody component from the physics engine
        // This allows manipulation of the object's physics
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
        // Set movement in X direction
        moveXDirection = Input.GetAxis("Horizontal");

        // Set movement in Y direction (This would float above the map)
        moveYDirection = 0.0f;

        // Set movement in Z direction
        moveZDirection = Input.GetAxis("Vertical");

        // Contain all movement directions in one Vector3 variable
        Vector3 movement = new Vector3(moveXDirection, 0.0f, moveZDirection);

        // Apply the movement direction multiplied by the speed to the object
        //rb.AddForce(movement * speed);

        movement = movement.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
	}
}
