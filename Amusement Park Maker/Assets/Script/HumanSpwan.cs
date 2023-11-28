using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpwan : MonoBehaviour
{
    public GameObject[] customerPrefabs; // 손님을 나타내는 프리팹
    public Transform[] spawnPoints; // 손님을 스폰할 위치 배열
    public float spawnDelay = 3f; // 손님 스폰 딜레이

    private float timeSinceLastSpawn = 0f;
    private int currentScore = 0;
    private bool canSpawn = true;

    void Update()
    {
        // 점수가 증가할 때마다 손님 스폰
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
        // 랜덤한 손님 프리팹 선택
        int randomIndex = Random.Range(0, customerPrefabs.Length);
        GameObject selectedCustomerPrefab = customerPrefabs[randomIndex];

        // 랜덤한 위치에서 손님 스폰
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnPointIndex];

        Instantiate(selectedCustomerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
