using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float angularVelocity;

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
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularVelocity, 0);
        }
        else 
        { 
         rb.angularVelocity = Vector3.zero;
        }
        
        

        
      
    }
}
