using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{
    private NavMeshAgent agent;
    private Vector3 destination;

    public float minWalkDistance = 5f;
    public float maxWalkDistance = 20f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetRandomDestination();
    }

    void SetRandomDestination()
    {
        float randomDistance = Random.Range(minWalkDistance, maxWalkDistance);
        Vector3 randomDirection = Random.insideUnitSphere * randomDistance;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, randomDistance, 1);
        destination = hit.position;
        agent.SetDestination(destination);
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            SetRandomDestination();
        }
    }
}
