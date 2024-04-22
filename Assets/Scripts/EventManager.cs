using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void CollisionAction(Collision collision);
    public static event CollisionAction OnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (OnCollision != null)
        {
            OnCollision(collision); 
        }
    }
}
