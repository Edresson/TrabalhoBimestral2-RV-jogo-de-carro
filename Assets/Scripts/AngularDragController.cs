using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
public class AngularDragController : MonoBehaviour
{
    //public GameObject Car;
    private Slider slider;
    private Rigidbody rb;










    public void Start()
    {
        
        if (GameObject.FindGameObjectWithTag ("slider")) {
                slider = (Slider) FindObjectOfType(typeof (Slider));
            }

        //slider = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Slider>(); 

        //Adds a listener to the main slider and invokes a method when the value changes.
        slider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
        rb = GetComponent<Rigidbody>();
    }
    public void ValueChangeCheck()
    {
        rb.angularDrag = slider.value;
    }

}
