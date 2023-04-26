using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    Rigidbody rb;
    float cameraMovementSpeed = 0.01f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public Vector3 nextCameraPosition;
    public Button1 button1;
    int M1 = 0;

    //camera positions
    public Vector3 cameraPos1;
    public Vector3 cameraPos2;
    public Vector3 cameraPos3;


    //functions

    public Vector3 NextCameraPosition(Vector3 nextCameraPos, Vector3 originalPosition, Vector3 targetPosition)
    {
        originalPosition = targetPosition;
        return originalPosition;
        targetPosition = nextCameraPos;
        return targetPosition;
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        button1 = GameObject.Find("CameraTo2").GetComponent<Button1>(); // find the Button1 script on the CameraTo2 object and get a reference to it
        targetPosition = cameraPos2;
        originalPosition = cameraPos1;
        nextCameraPosition = cameraPos3;
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraMovementSpeed);
            originalPosition = targetPosition;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, cameraMovementSpeed/2);
        }
        if(Input.GetKey(KeyCode.M))
        {
        }
    }
}

