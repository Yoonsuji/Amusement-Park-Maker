using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void ExitGame()
    {
        Application.Quit();
    }
}
