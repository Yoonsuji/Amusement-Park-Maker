using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //important

//if you use this code you are contractually obligated to like the YT video
public class RandomMove : MonoBehaviour //don't forget to change the script name if you haven't
{
    public float updateInterval = 3f; // ��ǥ ��ġ�� ������ �ð� ���� (��)
    private NavMeshAgent agent; // NavMeshAgent�� ������ ����
    private float timeSinceLastUpdate; // ���������� ��ǥ ��ġ�� �����ߴ� �ð�

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent ������Ʈ�� �����ɴϴ�.
        timeSinceLastUpdate = updateInterval; // �ʱ⿡ ��ǥ ��ġ�� �����ϱ� ���� �ð� ���� �����մϴ�.
    }

    void Update()
    {
        timeSinceLastUpdate += Time.deltaTime; // �ð� ���� �����մϴ�.

        if (timeSinceLastUpdate >= updateInterval) // ������ �ð� ������ �������� Ȯ���մϴ�.
        {
            Vector3 randomPosition = GetRandomPositionOnNavMesh(); // NavMesh ���� ������ ��ġ�� �����ɴϴ�.
            agent.SetDestination(randomPosition); // NavMeshAgent�� ��ǥ ��ġ�� ���� ��ġ�� �����մϴ�.
            timeSinceLastUpdate = 0f; // �ð� ���� �ʱ�ȭ�մϴ�.
        }
    }

    Vector3 GetRandomPositionOnNavMesh()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 20f; // ���ϴ� ���� ���� ������ ���� ���͸� �����մϴ�.
        randomDirection += transform.position; // ���� ���� ���͸� ���� ��ġ�� ���մϴ�.

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomDirection, out hit, 20f, NavMesh.AllAreas)) // ���� ��ġ�� NavMesh ���� �ִ��� Ȯ���մϴ�.
        {
            return hit.position; // NavMesh ���� ���� ��ġ�� ��ȯ�մϴ�.
        }
        else
        {
            return transform.position; // NavMesh ���� ���� ��ġ�� ã�� ���� ��� ���� ��ġ�� ��ȯ�մϴ�.
        }
    }
}

