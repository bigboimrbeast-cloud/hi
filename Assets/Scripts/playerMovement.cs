using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private float xMove;

    private float yMove;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * 10, rb.linearVelocity.y, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up*300);
        }
    }
    
}
