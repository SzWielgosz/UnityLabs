using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float speed = 2.5f;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10)
        {
            speed = -speed;
        }
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
