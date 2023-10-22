using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2.5f;
    private float distanceTraveled = 0f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        distanceTraveled += speed * Time.deltaTime;

        if (distanceTraveled >= 10)
        {
            transform.Rotate(0, 90f, 0);
            distanceTraveled = 0;
        }
    }
}
