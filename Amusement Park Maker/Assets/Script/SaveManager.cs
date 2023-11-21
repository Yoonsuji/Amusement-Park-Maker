using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public int[,] shopItems = new int[21,21];
    public float coins;
    public Text coinsTXT;

    void Start()
    {

        InvokeRepeating("IncreaseCoins", 5f, 5f);
        coinsTXT.text = "" + coins.ToString();

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;
        shopItems[1, 13] = 13;
        shopItems[1, 14] = 14;
        shopItems[1, 15] = 15;
        shopItems[1, 16] = 16;
        shopItems[1, 17] = 17;
        shopItems[1, 18] = 18;
        shopItems[1, 19] = 19;
        shopItems[1, 20] = 20;

        //Price
        shopItems[2, 1] = 500;
        shopItems[2, 2] = 500;
        shopItems[2, 3] = 600;
        shopItems[2, 4] = 600;
        shopItems[2, 5] = 400;
        shopItems[2, 6] = 100;
        shopItems[2, 7] = 100;
        shopItems[2, 8] = 100;
        shopItems[2, 9] = 100;
        shopItems[2, 10] = 100;
        shopItems[2, 11] = 100;
        shopItems[2, 12] = 100;
        shopItems[2, 13] = 100;
        shopItems[2, 14] = 100;
        shopItems[2, 15] = 100;
        shopItems[2, 16] = 100;
        shopItems[2, 17] = 100;
        shopItems[2, 18] = 100;
        shopItems[2, 19] = 100;
        shopItems[2, 20] = 100;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0;
        shopItems[3, 9] = 0;
        shopItems[3, 10] = 0;
        shopItems[3, 11] = 0;
        shopItems[3, 12] = 0;
        shopItems[3, 13] = 0;
        shopItems[3, 14] = 0;
        shopItems[3, 15] = 0;
        shopItems[3, 16] = 0;
        shopItems[3, 17] = 0;
        shopItems[3, 18] = 0;
        shopItems[3, 19] = 0;
        shopItems[3, 20] = 0;



    }

    void IncreaseCoins()
    {
        coins += 500;
        coinsTXT.text = coins.ToString();
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
