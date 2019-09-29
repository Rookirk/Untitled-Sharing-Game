using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

//Apparently I'm supposed to put this here to make sure
//that the script runs before everything else
//it helps it not make the game feel laggy
//GAMERS
[DefaultExecutionOrder(-100)]
public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    //The speed of the player
    public float speed;
    
    //Indicates which player is being played
    public float player1;
    
    
    //The movement vectors for movement.
    //Used to move the player with speed etc
    private Vector2 moveVelocity;
    //Used to move to set direction of the vector.
    private Vector2 moveInput = new Vector2(0,0);
    //Jump vector, you jump
    private Vector2 jumpVector = new Vector2(0, 800);
    
    //Jump Timer
    private float jumpTime = .5f;
    
    //Idk what the fuck this is it's the rigidbody so it's like the body of the character or something
    private Rigidbody2D rb;

    //Movement checks
    //States guide
    ///  0 = not being used
    ///  1 = being used
    ///  -1 = specifically for jumps, means that it is in the air
    private int leftCheck = 0;
    private int rightCheck = 0;
    private int jumpCheck = 0;
    
    void Start()
    {
        //Sets up the rigid body variable by getting the rigidbody from the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player 1 controls
        /// Checks if the person is player one and the correct inputs attached to it
        /// If the key is being used, 
        /// (playyer one is WASD, 2 is arrow keys)
        if (player1 == 1)
        {
            if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow))
                leftCheck = 1;
            if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.RightArrow))
                rightCheck = 1;
            if (Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.UpArrow) && jumpCheck == 0)
            {
                jumpCheck = 1;
                rb.AddForce(jumpVector);
            }
        }
        if (player1 == 2)
        {
            if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.A))
                leftCheck = 1;
            if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.D))
                rightCheck = 1;
            if (Input.GetKeyDown(KeyCode.UpArrow) && !Input.GetKeyDown(KeyCode.W) && jumpCheck == 0)
            {
                jumpCheck = 1;
                rb.AddForce(jumpVector);
            }
        }

        //Resets the the thing so you dont slide off into oblivion
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftCheck = 0;
            moveInput.x = 0;
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightCheck = 0;
            moveInput.x = 0;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            jumpCheck = -1;
            moveInput.y = -1;
        }
        
        //Counts down the time for when jumpCheck is at -1
        if(jumpCheck == -1)
            jumpTime -= Time.deltaTime;

        if (jumpTime <= 0.0f)
        {
            jumpCheck = 0;
            jumpTime = .5f;
        }
        
        //Points vector left
        if (leftCheck == 1)
            moveInput.x -= 1;
        
        //Points vector right
        if (rightCheck == 1)
            moveInput.x += 1;

        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        //Jump vector up
        if (jumpCheck == 1)
        {
            
        }

        rb.AddForce(moveVelocity);
    }
}
