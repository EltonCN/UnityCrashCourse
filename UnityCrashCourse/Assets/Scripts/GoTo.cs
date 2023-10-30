using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GoTo : MonoBehaviour
{
    [SerializeField] GameObject target;
    NavMeshAgent agent;

    Vector3 targetPosition = new();
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(target.transform.position != targetPosition)
        {
            targetPosition = target.transform.position;
            agent.SetDestination(targetPosition);
        }
    }
}