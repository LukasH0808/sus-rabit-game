using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public Rigidbody rb;
    public Vector3 forwardMovement;
    public float gravity = -9.81f;
    public void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (characterController.isGrounded)
        {
            Gravity();
            gravity -= 1f;
        }
        else
        {
            gravity = -9.81f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            
        }
    }
    private void Gravity()
    {
        rb.AddForce(transform.up * Time.deltaTime * gravity);
    }
}