using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    public float speed = 5f;
    public int score = 0;
    public int health = 100;

    private Vector2 direction = Vector2.right; // start richting
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.S)) direction = Vector2.down;

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Enemy")
        {
            health -= 100;

            if (health <= 0)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // Reload the current scene
    }
}