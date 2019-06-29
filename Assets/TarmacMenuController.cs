using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarmacMenuController : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position;
        float z = (transform.position.z <= -99.5 
            ? 100 
            : transform.position.z - (speed * Time.deltaTime));
        
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            z
        );
    }
}
