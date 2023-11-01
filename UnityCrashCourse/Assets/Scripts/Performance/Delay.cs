using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double startTime = Time.realtimeSinceStartupAsDouble;

        while (Time.realtimeSinceStartupAsDouble - startTime < 100e-3) ;
    }
}
