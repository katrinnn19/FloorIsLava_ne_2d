using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRotation : MonoBehaviour
{
    public Vector3 positionChange;
    void Update()
    {
        transform.position += positionChange;
    }
}
