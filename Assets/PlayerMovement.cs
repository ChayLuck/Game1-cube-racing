using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = -10f;
    public float sidewayForce = 10f;
    void FixedUpdate()
    {
        rb.AddForce(forwardForce, 0, 0 * Time.deltaTime);
        if (Input.GetKey("d") )
        {
            rb.AddForce(0, 0, sidewayForce);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -sidewayForce);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
