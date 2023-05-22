using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    Rigidbody rb;
    float cameraMovementSpeed = 0.2f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public Vector3 nextCameraPosition;

    //Camera triggers
    public Button1 Trigger1;
    public Button1 Trigger2;
    public Button1 Trigger3;
    public Button1 Trigger4;
    public Button1 Trigger5;

    //Camera positions
    public Vector3 cameraPos1;
    public Vector3 cameraPos2;
    public Vector3 cameraPos3;
    public Vector3 cameraPos4;
    public Vector3 cameraPos5;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Trigger1 = GameObject.Find("CameraTo1").GetComponent<Button1>();
        Trigger2 = GameObject.Find("CameraTo2").GetComponent<Button1>();
        Trigger3 = GameObject.Find("CameraTo3").GetComponent<Button1>();
        Trigger4 = GameObject.Find("CameraTo4").GetComponent<Button1>();
        Trigger5 = GameObject.Find("CameraToFinish").GetComponent<Button1>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Trigger1.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPos1, cameraMovementSpeed);
        }
        if(Trigger2.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPos2, cameraMovementSpeed);
        }
        if(Trigger3.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPos3, cameraMovementSpeed);
        }
        if(Trigger4.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPos4, cameraMovementSpeed);
        }
        if(Trigger5.ButtonActive1)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPos5, cameraMovementSpeed);
        }
    }
}

