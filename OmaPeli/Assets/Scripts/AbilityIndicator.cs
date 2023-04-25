using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityIndicator : MonoBehaviour
{

    public Vector3 indicatorPosition;
    public Vector3 abilityIndicator;

    // Start is called before the first frame update
    void Start()
    {
        indicatorPosition = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            transform.position = Vector3.Lerp(transform.position, indicatorPosition.abilityIndicator, 1);
        }
    }
}
