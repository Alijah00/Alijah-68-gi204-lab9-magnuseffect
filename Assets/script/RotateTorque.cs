using UnityEngine;

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
        rb.AddTorque (0, torquespeed, 0);
    }
   
}
