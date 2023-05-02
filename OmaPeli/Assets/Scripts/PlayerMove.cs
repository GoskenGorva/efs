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
    public Vector3 levelPosition;

    public Button1 Trigger1;
    public Button1 Trigger2;
    public Button1 Trigger3;
    public Button1 Trigger4;
    public Button1 Trigger5;

    public Vector3 PLPos1;
    public Vector3 PLPos2;
    public Vector3 PLPos3;
    public Vector3 PLPos4;
    public Vector3 PLPos5;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Trigger1 = GameObject.Find("CameraTo1").GetComponent<Button1>();
        Trigger2 = GameObject.Find("CameraTo2").GetComponent<Button1>();
        Trigger3 = GameObject.Find("CameraTo3").GetComponent<Button1>();
        Trigger4 = GameObject.Find("CameraTo4").GetComponent<Button1>();
        Trigger5 = GameObject.Find("CameraToFinish").GetComponent<Button1>();
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
        if(Trigger1.ButtonActive1)
        {
            levelPosition = PLPos1;
        }
        if(Trigger2.ButtonActive1)
        {
            levelPosition = PLPos2;
        }
        if(Trigger3.ButtonActive1)
        {
            levelPosition = PLPos3;
        }
        if(Trigger4.ButtonActive1)
        {
            levelPosition = PLPos4;
        }
        if(Trigger5.ButtonActive1)
        {
            levelPosition = PLPos5;
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
            transform.position = Vector3.Lerp(transform.position, levelPosition, 1);
            transform.Rotate(0f, 0f, 0f);
        }
        else
        {
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