using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ref_InputNew : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKey(InputAction.CallbackContext context)
    {
        transform.position = targetPosition;
    }
}
