using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Zad1 : MonoBehaviour
{
    public Material[] materials;
    public float delay = 3.0f;
    public int objectCounter = 0;
    public GameObject Object;
    private Bounds bounds;

    void Start()
    {
        bounds = GetComponent<Renderer>().bounds;

        StartCoroutine(GenerujObiekty());
    }

    IEnumerator GenerujObiekty()
    {
        Debug.Log("Wywo³ano coroutine");

        for (int i = 0; i < objectCounter; i++)
        {
            float randomX = Random.Range(bounds.min.x, bounds.max.x);
            float randomZ = Random.Range(bounds.min.z, bounds.max.z);
            Debug.Log("Random X:" + randomX + " Random Z:" + randomZ);
            
            Vector3 randomPosition = new Vector3(randomX, 2, randomZ);

            GameObject newObject = Instantiate(Object, randomPosition, Quaternion.identity);

            Material randomMaterial = materials[Random.Range(0, materials.Length)];
            newObject.GetComponent<Renderer>().material = randomMaterial;

            yield return new WaitForSeconds(delay);
        }
    }
}
