using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOGPos : MonoBehaviour
{

    public Vector3 originalPosition;
    public PlayerMove Trigger1;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        Trigger1 = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Trigger1.inputRestart)
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, 0);
        }
    }
}
