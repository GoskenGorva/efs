using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Components
    Rigidbody2D rb;

    //Muuttujat
    float walkSpeed = 4f;
    float inputVertical;
    float inputHorizontal;
    public bool inputShift;
    public bool inputRestart;
    int dashTimer = 0;
    int sprintSpeed = 10;
    public Vector3 playerPosition;

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
        
        //Run
        if(Input.GetKey(KeyCode.LeftShift))
        {
            inputShift = true;
        }
        else
        {
            inputShift = false;
        }

        //Ability1
        if(Input.GetKey(KeyCode.P)) 
        {
            playerPosition = transform.position;
        }
        if(Input.GetKey(KeyCode.L))
        {
            transform.position = Vector3.Lerp(transform.position, playerPosition, 1);
        }
        
        if(Input.GetKey(KeyCode.R))
        {
            inputRestart = true;
        }
        else{
            inputRestart = false;
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