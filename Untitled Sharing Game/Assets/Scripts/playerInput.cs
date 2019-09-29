using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apparently I'm supposed to put this here to make sure
//that the script runs before everything else
//it helps it not make the game feel laggy
[DefaultExecutionOrder(-100)]
public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
