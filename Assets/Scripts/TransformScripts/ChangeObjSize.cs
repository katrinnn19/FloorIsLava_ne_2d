using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjSize : MonoBehaviour
{
    private Rigidbody rb;
    public string targetTag = "Ball";
    public float shrinkFactor;
    public string[] collisionTags = {"JumpAndMakeSmallerPlatform" };
    private bool needToChangeSize = true;

    void OnEnable()
    {
        EventManager.OnCollision += ChangeObjectSize;
    }

    void OnDisable()
    {
        EventManager.OnCollision -= ChangeObjectSize;
    }
    private void Start()
    {
        GameObject objectsWithTag = GameObject.FindGameObjectWithTag(targetTag);
        rb = objectsWithTag.GetComponent<Rigidbody>();

    }
    private void ChangeObjectSize(Collision collision)
    {
        foreach (string tag in collisionTags)
        {
            if (collision.gameObject.CompareTag(tag) && needToChangeSize)
            {
                rb.gameObject.transform.localScale *= shrinkFactor;
                needToChangeSize = false;
            }
        }
    }
}

