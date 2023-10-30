using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryViewer : MonoBehaviour
{
    [SerializeField] GameObject itemsParent;
    [SerializeField] Inventory inventory;

    List<GameObject> texts = new();

    void OnEnable()
    {
        foreach(GameItem item in inventory.items)
        {
            string text = $"{item.itemName}: Attack {item.attack} | Durability {item.durability}";

            GameObject obj = new(item.name);
            obj.transform.parent = itemsParent.transform;

            TextMeshProUGUI textObject = obj.AddComponent<TextMeshProUGUI>();
            textObject.text = text;

            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(800, 50);

            texts.Add(obj);
        }
    }

    void OnDisable()
    {
        foreach(GameObject obj in texts)
        {
            Destroy(obj);
        }

        texts.Clear();
    }
}