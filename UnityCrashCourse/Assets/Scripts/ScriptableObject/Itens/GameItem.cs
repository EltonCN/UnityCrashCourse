using UnityEngine;

[CreateAssetMenu(menuName="ScriptableObjects/GameItem")]
public class GameItem : ScriptableObject
{
    public string itemName;
    public float attack;
    public float durability;
}
