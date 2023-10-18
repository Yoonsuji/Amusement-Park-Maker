using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Canvas main; 
    public Canvas shop;

    void Start()
    {
        main.enabled = true;
        shop.enabled = false;
    }

    public void OnButtonClick()
    {
        main.enabled = false;
        shop.enabled = true;
    }
}

