using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light1 : MonoBehaviour
{
    Rigidbody rb;
    float wallMovementSpeed = 0.3f;
    public Vector3 targetPosition;
    public Vector3 originalPosition;
    public BoxTrigger1 Trigger1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Trigger1 = GameObject.Find("ButtonP1").GetComponent<BoxTrigger1>(); 
        private Color m_oldColor = new Color(82f/255f, 82f/255f, 82f/255f);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(Trigger1.ButtonActive2)
        {
            m_oldColor = render.material.color;
            render.material.color = Color.green;
            ButtonActive2 = true;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, wallMovementSpeed);
            render.material.color = m_oldColor;
            ButtonActive2 = false;
        }
    }
}
