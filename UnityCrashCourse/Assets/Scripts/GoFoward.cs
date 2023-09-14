using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GoFoward : MonoBehaviour
{
    Rigidbody rb;
    bool onCollision;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        onCollision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(onCollision)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.velocity = new Vector3(1, 0, 0);
        }
        
    }

    void OnTriggerEnter()
    {
        onCollision = true;
    }

    void OnTriggerExit()
    {
        onCollision = false;
    }
}
