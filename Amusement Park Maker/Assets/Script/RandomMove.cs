using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform targerObject;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if(targerObject != null )
        {
            Debug.LogError("목표 물체 없음");
        }
        else
        {
            MoveToTarget();
        }
    }

    void MoveToTarget()
    {
        agent.SetDestination(targerObject.position);
    }
}
