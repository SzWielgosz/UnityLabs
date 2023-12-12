using UnityEngine;

public class Cheat : MonoBehaviour
{
    public string expectedSequence = "aezakmi";
    private string currentSequence = "";
    private GameObject player;

    private void Start()
    {
        player = gameObject;
    }
    void Update()
    {
        checkSequence();
    }

    void checkSequence()
    {
        currentSequence += Input.inputString;
        if (!expectedSequence.StartsWith(currentSequence))
        {
            currentSequence = "";
        }
        if (Input.anyKeyDown)
        {
            if (currentSequence.Contains(expectedSequence))
            {
                if (GameManager.Instance)
                {
                    GameManager.Instance.activateCheat(player);
                }
            }
        }
    }
}
