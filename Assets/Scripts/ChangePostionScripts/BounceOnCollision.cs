using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BounceOnCollision : MonoBehaviour
{
    public float bounceForce;
    public string targetTag = "Ball";
    public string[] collisionTags = { "JumpUpPlatform", "JumpAndMakeSmallerPlatform" };
    private Rigidbody rb;

    private void Start()
    {
        GameObject objectsWithTag = GameObject.FindGameObjectWithTag(targetTag);
        rb = objectsWithTag.GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        EventManager.OnCollision += ChangeBounce;
    }

    void OnDisable()
    {
        EventManager.OnCollision -= ChangeBounce;
    }

    private void ChangeBounce(Collision collision)
    {
        foreach(string tag in collisionTags)
        {
            if (collision.gameObject.CompareTag(tag))
            {
                rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            }
        }
    }
}
