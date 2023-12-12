using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSpawnPoint : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                Debug.Log("SpawnPoint set");
                GameManager.Instance.spawnPoint = gameObject;
            }
        }
    }
}
