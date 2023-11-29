using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int value = 1;
    private AudioSource parentAudioSource;
    private AudioClip collisionSound;
    private LateDestroy parentObjectDestroy;
    
    private void Start()
    {
        parentAudioSource = GetComponentInParent<AudioSource>();
        parentObjectDestroy = GetComponentInParent<LateDestroy>();
        collisionSound = parentAudioSource.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddMoney(value);
            if (parentAudioSource != null)
            {
                parentAudioSource.Play();
                parentObjectDestroy.destroyLate(collisionSound.length);
                Destroy(gameObject);
            }
        }
    }
}


