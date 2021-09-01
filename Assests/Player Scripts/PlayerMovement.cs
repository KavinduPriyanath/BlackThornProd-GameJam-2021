using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 12f;

    void Update ()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        rb.velocity = (transform.right * x) + (transform.forward * z) + (transform.up * rb.velocity.y);
    }
}
