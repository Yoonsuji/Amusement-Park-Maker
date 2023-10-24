using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectPlace : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreIncreaseAmount = 4;
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object_1"))
        {
            scoreManager.IncreaseScore(scoreIncreaseAmount);
            Destroy(gameObject);
            Debug.Log("Á¡¼ö");
        }
    }
}
