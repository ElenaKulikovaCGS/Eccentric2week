using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float ConstantValue;
    public float ForceValue = 10f;
    public float TorqueValue;

    private void FixedUpdate()
    {
        Rigidbody.AddForce(transform.forward * ConstantValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Rigidbody.AddForce(transform.forward * ForceValue, ForceMode.VelocityChange);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        Rigidbody.AddTorque(transform.right * TorqueValue * horizontalInput, ForceMode.VelocityChange);
    }
}
