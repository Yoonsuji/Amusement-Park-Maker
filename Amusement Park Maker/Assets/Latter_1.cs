using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Latter_1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject LatterDetail;
    // Start is called before the first frame update
    public void OnPointerExit(PointerEventData eventData)
    {
        LatterDetail.SetActive(false);
    }

    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        LatterDetail.SetActive(true);
    }
}
