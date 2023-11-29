using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int collectedMoney = 0;
    public List<int> requiredMoney;
    public List<GameObject> doors;
    public bool isGameEnded = false;

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
    }

    public void AddMoney(int value)
    {
        collectedMoney += value;
        for(int i = 0; i < doors.Count; i++)
        {
            if(collectedMoney >= requiredMoney[i])
            {
                UnlockDoor(i);
            }
        }
    }

    public void UnlockDoor(int value)
    {
        Debug.Log("Unlocking door");
        Destroy(doors[value]);
    }

    public void EndGame()
    {
        isGameEnded = true;
        TimeCounter.Instance.timeIsRunning = false;
    }

    void ResetGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
