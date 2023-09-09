using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ref_ChangePosition : MonoBehaviour
{
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 afterTimePosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3)
        {
            transform.position = afterTimePosition;
        }
    }
}
