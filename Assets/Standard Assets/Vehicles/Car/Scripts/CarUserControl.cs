using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private bool control;


        private void Awake()
        {
            control = SceneManager.GetActiveScene().name != "Menu";

            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            if (control) {
                    // pass the input to the car!
                    float h = CrossPlatformInputManager.GetAxis("Horizontal");
                    float v = CrossPlatformInputManager.GetAxis("Vertical");
                #if !MOBILE_INPUT
                    float handbrake = CrossPlatformInputManager.GetAxis("Jump");
                    m_Car.Move(h, v, v, handbrake);
                #else
                    m_Car.Move(h, v, v, 0f);
                #endif
            }
        }
    }
}
