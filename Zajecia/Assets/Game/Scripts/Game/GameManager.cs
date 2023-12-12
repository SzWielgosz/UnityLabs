using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int collectedMoney = 0;
    public List<int> requiredMoney;
    public List<GameObject> doors;
    public GameObject spawnPoint;
    public GameObject winPanel;
    public GameObject quitPanel;
    public GameObject endCrown;
    private bool isGameEnded = false;
    private bool isCheatActivated = false;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && isGameEnded)
        {
            ResetGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!quitPanel.activeSelf)
            {
                quitPanel.SetActive(true);
            }
            else
            {
                quitPanel.SetActive(false);
            }
        }
    }

    public void AddMoney(int value)
    {
        collectedMoney += value;
        for(int i = 0; i < doors.Count; i++)
        {
            if(collectedMoney >= requiredMoney[i])
            {
                Debug.Log("Unlocking doors");
                UnlockDoor(i);
                collectedMoney = 0;
            }
        }
    }

    public void UnlockDoor(int value)
    {
        Destroy(doors[value]);
        doors.RemoveAt(value);
        requiredMoney.RemoveAt(value);
    }

    public void EndGame()
    {
        Debug.Log("Game ended");
        isGameEnded = true;
        TimeCounter.Instance.timeIsRunning = false;
        winPanel.SetActive(true);
    }

    public void ResetGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void TeleportToSpawnPointAndStop(GameObject player)
    {
        player.transform.position = spawnPoint.transform.position;
        Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
        if (playerRigidbody != null)
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }

    public void activateCheat(GameObject player)
    {
        if (!isCheatActivated)
        {
            Debug.Log("Cheat activated");
            Transform playerTransform = player.GetComponent<Transform>();
            Vector3 newPosition = new Vector3(playerTransform.transform.position.x + 2, playerTransform.transform.position.y, playerTransform.transform.position.z);
            Instantiate(endCrown, newPosition, Quaternion.identity);
        }
    }
}
