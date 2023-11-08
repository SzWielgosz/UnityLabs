using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float sensitivity = 2.0f;
    private float rotationX = 0;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotationX -= mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.parent.rotation *= Quaternion.Euler(0, mouseX * sensitivity, 0);
    }
}
