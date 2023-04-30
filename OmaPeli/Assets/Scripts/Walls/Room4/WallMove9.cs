using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove9 : MonoBehaviour
{
    Rigidbody rb;
    float wallMovementSpeed = 0.7f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public Button2 button2;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        button2 = GameObject.Find("ButtonP5").GetComponent<Button2>(); 
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
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed/30);
        }
    }
}