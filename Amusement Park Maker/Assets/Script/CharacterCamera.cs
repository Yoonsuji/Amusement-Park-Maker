using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    public void OnMouseDown()
    {
        PC_CameraMove.instance.followTransform = transform;
    }
}
