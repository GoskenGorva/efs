using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityIndicator : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 indicatorPosition;
    [SerializeField] private GameObject PlayerPlaceHolder;

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
            transform.position = Vector3.Lerp(transform.position, PlayerPlaceHolder.transform.position, 1);
        }
    }
}
