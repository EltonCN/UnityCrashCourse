using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDestroy : MonoBehaviour
{
    List<GameObject> objs = new();
    float last;

    bool create = true;

    void Start()
    {
        last = Time.time;
    }

    void Update()
    {
        if(Time.time - last < 0.25)
        {
            return;
        }

        if(create)
        {
            for(int i = 0; i<10000; i++)
            {
                GameObject obj = new();
                obj.transform.parent = transform;

                objs.Add(obj);
            }
        }
        else
        {
            foreach(GameObject obj in objs)
            {
                Destroy(obj);
            }

            objs.Clear();
        }


        create = !create;
        last = Time.time;

    }
}
