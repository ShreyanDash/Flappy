using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private bool gameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Don't allow jumping after Game Over
        if (gameOver)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(0f, jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameOver)
        {
            return;
        }

        gameOver = true;

        Debug.Log("GAME OVER!");

        // Stop Amitabh's upward/jumping movement
        rb.linearVelocity = Vector2.zero;

        // Make gravity pull him down
        rb.gravityScale = 2f;
    }
}