using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove8 : MonoBehaviour
{
    Rigidbody rb;
    float wallMovementSpeed = 0.7f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public BoxTrigger1 button2;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        button2 = GameObject.Find("ButtonB4").GetComponent<BoxTrigger1>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(button2.ButtonActive2)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, wallMovementSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed/100);
        }
    }
}
