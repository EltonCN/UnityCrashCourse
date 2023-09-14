using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    [SerializeField] Vector3 onStartPosition;
    [SerializeField] Vector3 timePosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = onStartPosition;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3)
        {
            transform.position = timePosition;
        }
    }
}
