using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger1 : MonoBehaviour
{
    private Color m_oldColor = new Color(0f/255f, 34f/255f, 255f/255f);
    public bool ButtonActive2;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.name == "Box1")
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            m_oldColor = render.material.color;
            render.material.color = Color.green;
            ButtonActive2 = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Box1")
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            render.material.color = m_oldColor;
            ButtonActive2 = false;
        }   
    }
}
