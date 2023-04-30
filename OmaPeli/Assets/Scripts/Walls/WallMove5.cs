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
    public Light3 Trigger3;
    public Light4 Trigger4;
    public Light5 Trigger5;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Trigger1 = GameObject.Find("ButtonB2").GetComponent<BoxTrigger1>();
        Trigger3 = GameObject.Find("Light3").GetComponent<Light3>();
        Trigger4 = GameObject.Find("Light4").GetComponent<Light4>();
        Trigger5 = GameObject.Find("Light5").GetComponent<Light5>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Trigger3.ButtonActive2 && Trigger4.ButtonActive2 && Trigger5.ButtonActive2)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, wallMovementSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed);
        }
    }
}
