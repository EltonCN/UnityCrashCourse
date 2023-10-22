using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Ref_WalkController : MonoBehaviour
{
    [SerializeField][Range(-1, 1)] float speed;
    [SerializeField][Range(-1, 1)] float side;

    Animator animator;

    int speedID;
    int sideID;

    void Start()
    {
        animator = GetComponent<Animator>();
        
        speedID = Animator.StringToHash("Speed");
        sideID = Animator.StringToHash("Side");
    }

    void Update()
    {
        animator.SetFloat(speedID, speed);
        animator.SetFloat(sideID, side);
    }
}
