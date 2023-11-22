using System.Collections;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public Transform spawnPoint; // 손님 생성 위치
    public GameObject[] customerPrefabs; // 여러 손님 프리팹
    public float initialSpawnDelay = 5f; // 초기 생성 지연 시간
    public float minSpawnDelay = 1f; // 최소 생성 지연 시간
    public float maxSpawnDelay = 5f; // 최대 생성 지연 시간

    public ScoreManager scoreManager; // 현재 점수

    void Start()
    {
        StartCoroutine(SpawnCustomers());
    }

    IEnumerator SpawnCustomers()
    {
        yield return new WaitForSeconds(initialSpawnDelay);

        while (true)
        {
            // 현재 점수가 높을수록 랜덤으로 손님 생성
            int randomScore = Random.Range(0, 100);
            if (randomScore < scoreManager.score)
            {
                SpawnCustomer();
            }

            float spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    void SpawnCustomer()
    {
        // 랜덤으로 손님 프리팹 선택
        GameObject customerPrefab = customerPrefabs[Random.Range(0, customerPrefabs.Length)];

        GameObject customer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        StartCoroutine(MoveAndDestroyCustomer(customer));
    }

    IEnumerator MoveAndDestroyCustomer(GameObject customer)
    {
        yield return new WaitForSeconds(15f); 
        Destroy(customer);
    }

    // 점수를 증가시키는 메서드
    public void IncreaseScore()
    {
        scoreManager.score++;
    }
}
