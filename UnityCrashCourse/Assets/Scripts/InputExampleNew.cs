using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputExampleNew : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;

    public void ReiceveMoveKey(InputAction.CallbackContext context)
    {
        transform.position = targetPosition;
    }
}
