using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSetting : MonoBehaviour
{
    void Start()
    {
        // Rigidbody ����
        Rigidbody terrainRigidbody = gameObject.GetComponent<Rigidbody>();
        if (terrainRigidbody == null)
        {
            terrainRigidbody = gameObject.AddComponent<Rigidbody>();
        }
        terrainRigidbody.isKinematic = true;

        // Rigidbody�� Constraints ����
        terrainRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
