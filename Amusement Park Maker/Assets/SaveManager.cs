using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public int[,] shopItems = new int[6,6];
    public float coins;
    public Text coinsTXT;

    void Start()
    {
        coinsTXT.text = "" + coins.ToString();

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;

        //Price
        shopItems[2, 1] = 500;
        shopItems[2, 2] = 500;
        shopItems[2, 3] = 600;
        shopItems[2, 4] = 600;
        shopItems[2, 5] = 400;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;



    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            coinsTXT.text = "" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        
        }
        else
        {
            Debug.Log("코인부족");
        }
    }
}
