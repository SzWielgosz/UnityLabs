using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    private bool playerNearby;
    private float speed = 2.0f;
    private Transform firstchild;
    private Transform secondchild;
    private float openAmount = 0.0f;

    public void Start()
    {
        playerNearby = false;
        firstchild = transform.GetChild(0);
        secondchild = transform.GetChild(1);
    }

    private void Update()
    {
        if (playerNearby)
        {
            if(openAmount < 2.0f)
            {
                openAmount += speed * Time.deltaTime;

                firstchild.Translate(Vector3.left * speed * Time.deltaTime);
                secondchild.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
        else
        {
            if(openAmount >= 0.0f)
            {
                openAmount -= speed * Time.deltaTime;

                firstchild.Translate(-Vector3.left * speed * Time.deltaTime);
                secondchild.Translate(-Vector3.right * speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER! OTWIERAC!");
            playerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player poszedl! Zamykamy!");
            playerNearby = false;
        }
    }
}
