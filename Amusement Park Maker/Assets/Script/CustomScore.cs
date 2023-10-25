using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomScore : MonoBehaviour
{
    ScoreManager scoreManager;
    // Start is called before the first frame update
    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ground"))
        {
            scoreManager.IncreaseScore(4);
            Debug.Log("점수 증가");
        }
    }
    // Update is called once per frame

}
