using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove10 : MonoBehaviour
{
    Rigidbody rb;
    float wallMovementSpeed = 0.7f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public Light6 button6;
    public Light7 button7;
    public Light8 button8;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        button6 = GameObject.Find("Light6").GetComponent<Light6>();
        button7 = GameObject.Find("Light7").GetComponent<Light7>(); 
        button8 = GameObject.Find("Light8").GetComponent<Light8>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(button6.ButtonActive2 && button7.ButtonActive2 && button8.ButtonActive2)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, wallMovementSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed/100);
        }
    }
}