using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="ScriptableObjects/AttackType")]
public class AttackType : ScriptableObject
{
    [SerializeField] public AttackType counter;

    void OnValidate()
    {
        if(counter)
        {
            counter.counter = this;
        }
    }
}
