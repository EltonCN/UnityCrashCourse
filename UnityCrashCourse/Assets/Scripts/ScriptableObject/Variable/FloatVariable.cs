using UnityEngine;

[CreateAssetMenu(menuName="ScriptableObjects/Float Variable")]
public class FloatVariable : ScriptableObject
{
    public float value;

    public void Add(float value)
    {
        this.value += value;
    } 
}
