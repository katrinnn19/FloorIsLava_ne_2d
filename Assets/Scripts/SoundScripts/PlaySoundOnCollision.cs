using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    public AudioClip collisionSound;
    private string objectTag;
    bool needToPlay = true;
    private void Start()
    {
        objectTag = this.tag;
    }
    void OnEnable()
    {
        EventManager.OnCollision += PlaySound;
    }

    void OnDisable()
    {
        EventManager.OnCollision -= PlaySound;
    }

    private void PlaySound(Collision collision)
    {
        if (collision.gameObject.CompareTag(tag) && needToPlay) 
        {
            AudioSource audioSource = GetComponent<AudioSource>();

            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }

            audioSource.clip = collisionSound;
            audioSource.Play();
            if(tag == "Finish")
            {
                needToPlay = false;
            }
        }
    }
}
