using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSetting : MonoBehaviour
{
    void Start()
    {
        // Rigidbody 설정
        Rigidbody terrainRigidbody = gameObject.GetComponent<Rigidbody>();
        if (terrainRigidbody == null)
        {
            terrainRigidbody = gameObject.AddComponent<Rigidbody>();
        }
        terrainRigidbody.isKinematic = true;

        // Rigidbody의 Constraints 설정
        terrainRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
