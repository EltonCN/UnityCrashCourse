using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ref_InputOld : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position = targetPosition;
        }
    }
}
