using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 30;

    void Update()
    {
        float angle = rotationSpeed * Time.deltaTime;
        Quaternion deltaRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation *= deltaRotation;
    }
}
