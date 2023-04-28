using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove5 : MonoBehaviour
{
    Rigidbody rb;
    float wallMovementSpeed = 0.01f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public BoxTrigger1 Trigger1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Trigger1 = GameObject.Find("ButtonB2").GetComponent<BoxTrigger1>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Trigger1.ButtonActive2)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, wallMovementSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed/2);
        }
    }
}
