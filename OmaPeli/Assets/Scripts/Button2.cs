using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color m_oldColor = new Color(192f/255f, 12f/255f, 12f/255f);
    public bool ButtonActive2;

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Johoo");
        if(other.gameObject.tag == "Player")
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            m_oldColor = render.material.color;
            render.material.color = Color.green;
            ButtonActive2 = true;
            print("Ehei");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            render.material.color = m_oldColor;
            ButtonActive2 = false;
        }   
    }
}