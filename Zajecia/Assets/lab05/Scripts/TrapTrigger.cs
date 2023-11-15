using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Debug.Log("Player dotknal przeszkody!");
        }
    }
}