using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOGPos : MonoBehaviour
{

    public Vector3 originalPosition;
    public Quaternion originalRotation;
    public PlayerMove Trigger1;
    float orgX;
    float orgY;
    float orgZ;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        Trigger1 = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
        orgX = transform.rotation.x;
        orgY = transform.rotation.y;
        orgZ = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(Trigger1.inputRestart)
        {
            transform.Rotate(orgX, orgY, orgZ);    
            transform.position = Vector3.Lerp(transform.position, originalPosition, 0);
            transform.rotation = originalRotation;
        }
    }
}
