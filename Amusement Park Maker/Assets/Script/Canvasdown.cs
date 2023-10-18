using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvasdown : MonoBehaviour
{
    public Canvas main;
    public Canvas setting;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && setting.enabled)
        {
            CloseSetting();
        }
    }

    public void CloseSetting()
    {
        main.enabled= true;
        setting.enabled= false;
    }
}
