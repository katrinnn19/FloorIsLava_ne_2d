using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target;
    [Range(0f, 10f)]
    public float distance = 5f;
    [Range(1f, 5f)]
    public float height = 3f;
    [Range(0f, 7f)]
    public float rotationSpeed = 2f; 

    private void LateUpdate()
    {
        if (target != null)
        {
           // float desiredAngle = target.eulerAngles.y;
           // Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
            Vector3 targetPosition = target.position - (Vector3.forward * distance) + (Vector3.up * height);

            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * rotationSpeed);
            transform.LookAt(target.position);
        }
    }
}
