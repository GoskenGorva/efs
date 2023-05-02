using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOGPos : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector3 originalPosition;
    public PlayerMove Trigger1;
    public GameObject PlayerPlaceHolder;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        //Trigger1 = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            rb.angularVelocity = 0;
            print("jis");
            transform.rotation = PlayerPlaceHolder.transform.rotation;
            transform.position = Vector3.Lerp(transform.position, originalPosition, 0);
        }
    }
}
