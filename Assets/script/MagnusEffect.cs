using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float kickForce;
    public float curve;
    public float magnus = 0.5f;

    Rigidbody rb;
    bool isShot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot)
        {
            rb.AddForce(Vector3.forward *  kickForce,ForceMode.Impulse);

            rb.AddTorque(Vector3.up * curve);

            isShot = true;
        }

       
    }
   void FixedUpdate()
    {
        if (!isShot) return;

        Vector3 velocity = rb.linearVelocity;
        Vector3 curve = rb.angularVelocity;

        Vector3 magnusForce = magnus * Vector3.Cross(velocity, curve);

        rb.AddForce(magnusForce);
        
        
          
    }

}
