using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    private bool playerInElevator = false;
    private bool goingUp = true;
    private float distanceTraveled = 0f;
    public float elevatorSpeed = 0.5f;
    public float elevatorDistance = 5f;
    private Vector3 initialPosition;
    private Vector3 initialParentPosition;

    private void Start()
    {
        initialPosition = transform.position;
        initialParentPosition = transform.parent.position;
    }

    private void Update()
    {
        if (playerInElevator)
        {
            float newY = Time.deltaTime * elevatorSpeed;

            if (goingUp)
            {
                if (distanceTraveled < elevatorDistance)
                {
                    MoveElevator(newY);
                }
                else
                {
                    goingUp = false;
                }
            }
            else
            {
                if (distanceTraveled > 0)
                {
                    MoveElevator(-newY);
                }
                else
                {
                    goingUp=true;
                }
            }
        }
    }

    private void MoveElevator(float offset)
    {
        transform.localPosition += new Vector3(0f, offset, 0f);
        transform.parent.localPosition += new Vector3(0f, offset, 0f);
        distanceTraveled += offset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player wszedl do windy");
            playerInElevator = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player wyszedl z windy");
            playerInElevator = false;
        }
    }
}
