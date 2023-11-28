using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpwan : MonoBehaviour
{
    public GameObject[] customerPrefabs; // �մ��� ��Ÿ���� ������
    public Transform[] spawnPoints; // �մ��� ������ ��ġ �迭
    public float spawnDelay = 3f; // �մ� ���� ������

    private float timeSinceLastSpawn = 0f;
    private int currentScore = 0;
    private bool canSpawn = true;

    void Update()
    {
        // ������ ������ ������ �մ� ����
        if (currentScore < ScoreManager.Instance.Score)
        {
            currentScore = ScoreManager.Instance.Score;
            canSpawn = true;
        }

        if (canSpawn)
        {
            timeSinceLastSpawn += Time.deltaTime;

            if (timeSinceLastSpawn >= spawnDelay)
            {
                SpawnCustomer();
                timeSinceLastSpawn = 0f;
            }
        }
    }

    void SpawnCustomer()
    {
        // ������ �մ� ������ ����
        int randomIndex = Random.Range(0, customerPrefabs.Length);
        GameObject selectedCustomerPrefab = customerPrefabs[randomIndex];

        // ������ ��ġ���� �մ� ����
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnPointIndex];

        Instantiate(selectedCustomerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
