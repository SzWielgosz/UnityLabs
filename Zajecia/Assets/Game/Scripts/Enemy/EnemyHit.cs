using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(GameManager.Instance != null)
            {
                GameManager.Instance.TeleportToSpawnPointAndStop(other.gameObject);
            }
        }
    }
}
