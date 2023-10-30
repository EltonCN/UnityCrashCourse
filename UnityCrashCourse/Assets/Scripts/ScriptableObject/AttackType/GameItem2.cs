using UnityEngine;

[CreateAssetMenu(menuName="ScriptableObjects/GameItem2")]
public class GameItem2 : ScriptableObject
{
    public string itemName;
    public float attack;
    public float durability;

    public AttackType attackType;
}
