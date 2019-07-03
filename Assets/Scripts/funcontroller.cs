using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcontroller : MonoBehaviour
{
    public float spinSpeed = 70.0f;
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(10000000000000000000*Time.deltaTime,0,0);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        
        //GetComponent<Rigidbody>().rotation = (spinSpeed*Time.deltaTime,0.0f,0.0f,0.0f);

        transform.Rotate(0,0,spinSpeed*Time.deltaTime);
    }


    
}
