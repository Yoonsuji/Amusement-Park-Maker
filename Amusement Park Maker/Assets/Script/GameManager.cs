using System.Collections;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public Transform spawnPoint; // �մ� ���� ��ġ
    public GameObject[] customerPrefabs; // ���� �մ� ������
    public float initialSpawnDelay = 5f; // �ʱ� ���� ���� �ð�
    public float minSpawnDelay = 1f; // �ּ� ���� ���� �ð�
    public float maxSpawnDelay = 5f; // �ִ� ���� ���� �ð�

    public ScoreManager scoreManager; // ���� ����

    void Start()
    {
        StartCoroutine(SpawnCustomers());
    }

    IEnumerator SpawnCustomers()
    {
        yield return new WaitForSeconds(initialSpawnDelay);

        while (true)
        {
            // ���� ������ �������� �������� �մ� ����
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
        // �������� �մ� ������ ����
        GameObject customerPrefab = customerPrefabs[Random.Range(0, customerPrefabs.Length)];

        GameObject customer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        StartCoroutine(MoveAndDestroyCustomer(customer));
    }

    IEnumerator MoveAndDestroyCustomer(GameObject customer)
    {
        yield return new WaitForSeconds(15f); 
        Destroy(customer);
    }

    // ������ ������Ű�� �޼���
    public void IncreaseScore()
    {
        scoreManager.score++;
    }
}
