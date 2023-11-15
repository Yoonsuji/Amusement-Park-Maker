using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatterClick : MonoBehaviour
{
    public GameObject Latter1;
    public GameObject Latter2;
    public GameObject Latter3;
    public GameObject Latter4;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        Latter1.SetActive(false);
        Latter2.SetActive(false);
        Latter3.SetActive(false);
        Latter4.SetActive(false);
        scoreManager = GameObject.Find("ScoreSystem").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    private void CheckScoreAndActivate()
    {
        Debug.Log("Score: " + scoreManager.score);
        if (scoreManager != null && scoreManager.score == 8)
        {
            Latter1.SetActive(true);
        }
        if (scoreManager != null && scoreManager.score == 16)
        {
            Latter2.SetActive(true);
        }
        if (scoreManager != null && scoreManager.score == 24)
        {
            Latter3.SetActive(true);
        }
        if (scoreManager != null && scoreManager.score == 32)
        {
            Latter4.SetActive(true);
        }
    }

    void Update()
    {
        CheckScoreAndActivate();
    }
}
