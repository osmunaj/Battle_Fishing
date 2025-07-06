using UnityEngine;

using System.Collections;
using System.Collections.Generic;



public class player_movoement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private Rigidbody2D rb;
    public float walkForce = 20;
    public float jumpForce = 10;

    public float gravityScale;

    public bool grounded;


    public float horizontalVelocity;
    public float verticalVelocity;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (grounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        
        if (!grounded)
        {
            applyGravity();

        }
        rb.linearVelocity = new Vector2(horizontalVelocity, verticalVelocity);
    }

    private void FixedUpdate()
    {
        Walk(Input.GetAxisRaw("Horizontal"));
        isGrounded();
    }

    private void Walk(float walkInput)
    {
        horizontalVelocity = walkInput * walkForce;
    }

    private void Jump()
    {
        verticalVelocity = jumpForce;
    }

    private void applyGravity()
    {
        verticalVelocity -= gravityScale/50;
    }

    private void isGrounded()
    {
        grounded = Physics2D.CircleCast(transform.position, 0.5f, Vector2.down, 0.9f);

        // if (grounded)
        // {
        //     verticalVelocity = 0;
        // }
    }

}
