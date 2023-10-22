using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad5 : MonoBehaviour
{
    public GameObject prefab;
    public int prefabNumber = 10;
    private List<Vector3> occupiedPositions = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefabNumber; i++)
        {
            Vector3 randomPosition = getRandomPosition();
            Instantiate(prefab, randomPosition, Quaternion.identity);
            occupiedPositions.Add(randomPosition);
        }
    }

    Vector3 getRandomPosition()
    {
        Vector3 position = new Vector3(0, 0, 0);
        bool isOccupied = true;

        while (isOccupied)
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            position = new Vector3(x, 5, z);
            isOccupied = occupiedPositions.Contains(position);
        }

        return position;
    }
}
