using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{

    public TextMeshProUGUI gameOverText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(GameManager.Instance != null)
            {
                Debug.Log("Game ended");
                GameManager.Instance.EndGame();
                gameOverText.enabled = true;
            }
        }
    }
}
