using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPosition : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = this.gameObject;
    }
    void Update()
    {
        if(player.transform.position.y < -20)
        {
            GameManager.Instance.TeleportToSpawnPointAndStop(player);
        }
    }
}
