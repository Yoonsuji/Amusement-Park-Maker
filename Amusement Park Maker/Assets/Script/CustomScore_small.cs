using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomScore_small : MonoBehaviour
{
    ScoreManager scoreManager;
    // Start is called before the first frame update
    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            scoreManager.IncreaseScore(2);
            Debug.Log("���� ����");
        }
    }
    // Update is called once per frame

}

