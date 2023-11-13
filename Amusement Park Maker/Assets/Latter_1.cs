using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Latter_1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject LatterDetail;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreSystem").GetComponent<ScoreManager>();
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnPointerExit(PointerEventData eventData)
    {
        LatterDetail.SetActive(false);
    }

    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        LatterDetail.SetActive(true);
        CheckScoreAndActivate();
    }
    private void CheckScoreAndActivate()
    {
        if (scoreManager != null && scoreManager.score == 8)
        {
            gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        CheckScoreAndActivate();
    }
}
