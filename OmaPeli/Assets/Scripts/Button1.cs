using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Notes
//other.GetComponent<Collider2D>().gameObject.name == "PlayerPlaceHolder"


public class Button1 : MonoBehaviour
{
    public bool ButtonActive1;

    void OnTriggerEnter2D(Collider2D other)
    {
        print("1");
        if(Input.GetKeyDown(KeyCode.M))
        {
            print("2");
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            ButtonActive1 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "PlayerPlaceHolder")
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            ButtonActive1 = false;
        }   
    }
}