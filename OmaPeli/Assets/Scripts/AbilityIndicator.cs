using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityIndicator : MonoBehaviour
{
    public GameObject PlayerPlaceHolder;
    public GameObject Mark;

    // Start is called before the first frame update
    void Start()
    {
        
        //indicatorPosition = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
    }
    // Upd  ate is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            Mark.transform.position = PlayerPlaceHolder.transform.position;
            Mark.transform.rotation = PlayerPlaceHolder.transform.rotation;
        }
    }
}
