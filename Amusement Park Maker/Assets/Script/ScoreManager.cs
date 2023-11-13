using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    // Start is called before the first frame update

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        UpdateScore();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "" + score;
    }

}
