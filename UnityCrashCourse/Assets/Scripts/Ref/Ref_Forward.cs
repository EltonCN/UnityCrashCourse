using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ref_Forward : MonoBehaviour
{
    [SerializeField] float velocity;

    bool colliding;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        colliding = false;    
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(colliding)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.velocity = new Vector3(velocity, 0, 0);
        }
    }

    void OnCollisionEnter()
    {
        colliding = true;
    }

    void OnCollisionExit()
    {
        colliding = false;
    }
}
