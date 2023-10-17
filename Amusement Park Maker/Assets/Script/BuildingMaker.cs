using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuildingMaker : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject pendingObject;

    private Vector3 pos;
    private RaycastHit hit;
    [SerializeField] private LayerMask layerMask;

    private bool objectPlaced = false;
    private void Update()
    {
        if(pendingObject != null)
        {
            pendingObject.transform.position = pos;
            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(pendingObject, hit.point, Quaternion.identity);
                PlaceObject();
                objectPlaced = true;
            }

        }
    }

    public void PlaceObject()
    {
        pendingObject = null;
        objectPlaced = false;
    }
    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            pos = hit.point;
        }
    }

    public void SelectObjecet(int index)
    {
        if (pendingObject == null)
        {
            pendingObject = Instantiate(objects[index], pos, transform.rotation);
        }
    }
}
