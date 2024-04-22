using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public Vector3 rotateChange;

    void Update()
    {
        if(Time.deltaTime != 0)
        {
            transform.Rotate(rotateChange);
        }
    }
}
