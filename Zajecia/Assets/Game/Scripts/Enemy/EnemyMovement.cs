using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int rightDirectionSpeed;
    public int forwardDirectionSpeed;

    void Update()
    {
        transform.Translate(new Vector3(rightDirectionSpeed * Time.deltaTime, 0, forwardDirectionSpeed * Time.deltaTime));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            if(rightDirectionSpeed != 0)
            {
                rightDirectionSpeed *= -1;
            }
            if(forwardDirectionSpeed != 0)
            {
                forwardDirectionSpeed *= -1;
            }
        }
    }
}
