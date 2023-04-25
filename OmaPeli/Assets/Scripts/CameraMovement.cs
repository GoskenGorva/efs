using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    Rigidbody rb;
    float cameraMovementSpeed = 0.1f;
    public Vector3 targetPosition;
    public Button1 button1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        button1 = GameObject.Find("Camera1to2").GetComponent<Button1>(); // find the Button1 script on the Camera1to2 object and get a reference to it
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraMovementSpeed);
        }
    }
}

