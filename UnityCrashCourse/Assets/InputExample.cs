using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputExample : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = targetPosition;
        }

        SceneManager.LoadScene("");
    }
}
