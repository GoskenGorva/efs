using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Components
    Rigidbody2D rb;

    //Muuttujat
    float walkSpeed = 4f;
    float speedLimiter = 0.7f;
    float inputVertical;
    float inputHorizontal;
    public bool inputShift;
    int dashTimer = 0;
    int sprintSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        
        if(Input.GetKey(KeyCode.LeftShift)) //Shift input detection
        {
            inputShift = true;
        }
        else
        {
            inputShift = false;
        }
    }

    void FixedUpdate()
    {
        //Movement & Sprint
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
            if (inputShift) //Sprint
            {   
                walkSpeed = 8; //Sprint speed
            }
            else //Regular movement
            {
                walkSpeed = 4;
            }
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f); //Stand
        }
    }
}