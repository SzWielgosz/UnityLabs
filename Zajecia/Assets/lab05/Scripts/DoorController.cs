using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool doorOpened;
    private Quaternion initialRotation;
    private Quaternion initialParentRotation;
    public float rotationSpeed = 90f;

    void Start()
    {
        initialRotation = transform.rotation;
        initialParentRotation = transform.parent.rotation;
        doorOpened = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !doorOpened)
        {
            Debug.Log("Player wykryty! Otwieramy drzwi");
            doorOpened = true;
            RotateDoor(90f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && doorOpened)
        {
            Debug.Log("Player sobie poszed³! Zamykamy drzwi");
            doorOpened = false;
            RotateDoor(0f);
        }
    }

    private void RotateDoor(float targetAngle)
    {
        Quaternion targetRotation = Quaternion.Euler(0f, targetAngle, 0f);
        transform.parent.rotation = targetRotation;
    }
}
