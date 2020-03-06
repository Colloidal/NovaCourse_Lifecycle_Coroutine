using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aaaaa : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce,0);
        }
    }
}
