using System;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jumpForce;
    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void Jump()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * jumpForce);
    }
}
