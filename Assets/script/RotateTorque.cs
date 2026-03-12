using UnityEngine;
using UnityEngine.InputSystem;

public class RotateTorque : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float torquespeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(0, torquespeed, 0);
        }
    }

}
