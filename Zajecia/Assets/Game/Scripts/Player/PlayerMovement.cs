using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.right * speed);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-Vector3.right * speed);
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.forward * speed);
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(-Vector3.forward * speed);
        }
    }
}
