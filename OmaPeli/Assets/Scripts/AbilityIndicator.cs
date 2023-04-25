using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityIndicator : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 indicatorPosition;
    //public PlayerMove abilityIndicator;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //indicatorPosition = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
    }
    // Upd  ate is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            //transform.position = Vector3.Lerp(transform.position, indicatorPosition.abilityIndicator, 1);
        }
    }
}
