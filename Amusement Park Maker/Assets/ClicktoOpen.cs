using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoOpen : MonoBehaviour
{
    public GameObject Inventory1;
    public GameObject Inventory2;

    // Start is called before the first frame update
    public void OpenotherInventory()
    {
        Inventory1.SetActive(false);
        Inventory2.SetActive(true);
    }

    // Update is called once per frame
    public void OpenInventory()
    {
        Inventory1.SetActive(true);
        Inventory2.SetActive(false);
    }
}
