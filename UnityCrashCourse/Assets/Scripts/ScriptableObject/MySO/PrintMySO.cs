using UnityEngine;
public class PrintMySO : MonoBehaviour
{
    [SerializeField] MySO so;

    void Start()
    {
        print($"{so.name} value: {so.variable}");
    }
}
