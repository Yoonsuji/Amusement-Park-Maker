using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PirceText;
    public Text QuantityTxt;
    public GameObject SaveManager;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        PirceText.text = "" + SaveManager.GetComponent<SaveManager>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = SaveManager.GetComponent<SaveManager>().shopItems[3, ItemID].ToString();
        

    }
}
