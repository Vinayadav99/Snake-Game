using UnityEngine;

public class SnakeMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 100f;
    public float jumpForce = 10000f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (transform.position.y >= 0.24)
        {
            rb.AddForce(0, -100, 0);
        }

    }
}
