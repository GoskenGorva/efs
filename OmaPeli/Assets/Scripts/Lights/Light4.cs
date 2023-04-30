using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light4 : MonoBehaviour
{
    Rigidbody rb;
    public BoxTrigger1 Trigger1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Trigger1 = GameObject.Find("ButtonB2").GetComponent<BoxTrigger1>();
    }
    private Color m_oldColor = new Color(82f/255f, 82f/255f, 82f/255f);
    public bool ButtonActive2;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Trigger1.ButtonActive2)
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            render.material.color = Color.green;
            ButtonActive2 = true;
        }
        else
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            render.material.color = m_oldColor;
            ButtonActive2 = false;
        }
    }
}
