using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    // References
    private Rigidbody2D rb;

    // Floates
    private float move;

    public float move_spd;
    public float jumpVelocity;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move_spd*move, rb.velocity.y, 0);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
	}
}
