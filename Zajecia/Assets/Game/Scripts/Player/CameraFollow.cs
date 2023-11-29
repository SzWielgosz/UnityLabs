using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + offset;   
    }
}
