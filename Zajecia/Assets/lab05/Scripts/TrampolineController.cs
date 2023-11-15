using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    public float launchForceMultiplier = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player wszedl na trampoline. Pora na wystrzal!");
            LaunchPlayer(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player zszedl z trampoliny");
        }
    }

    private void LaunchPlayer(Collider other)
    {
        Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

        if (playerRigidbody != null)
        {
            Vector3 launchDirection = transform.up;
            float launchForce = playerRigidbody.mass * Physics.gravity.magnitude * launchForceMultiplier;

            playerRigidbody.AddForce(launchDirection * launchForce, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Wymagane Rigidbody ¿eby wystrzeliæ");
        }
    }
}
