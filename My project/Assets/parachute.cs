using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachute : MonoBehaviour
{
    int c = 0;
    private bool j;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
        j = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Space")){
            //Debug.Log("space pressed!");
            rb.isKinematic = false;
        }
        if(Input.GetButton("LeftCtrl")){
            //Debug.Log("left ctrl pressed!");
            rb.drag = 15;
        }



    }
}
