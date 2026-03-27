using UnityEngine;
public class PacmanMovement : MonoBehaviour
{

    public float speed = 2f;
    public int score = 0;
    public int health = 100;
    public int coins = 0;
    public static int goldenRings = 0;
    private Vector2 direction = Vector2.right; // start richting
    private Vector3 originalScale;
    public GameObject EndUI;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W)) direction = Vector2.up;
        // if (Input.GetKeyDown(KeyCode.S)) direction = Vector2.down;

        Debug.Log("VerticalController: " + Input.GetAxis("VerticalController"));
        if (Input.GetAxis("VerticalController") > 0.99f) direction = Vector3.up;
        if (Input.GetAxis("VerticalController") < -0.99f) direction = Vector3.down;
        if (Input.GetAxis("HorizontalController") < -0.99f)
        {
            direction = Vector3.left;
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z); 
        }
         
        if (Input.GetAxis("HorizontalController") > 0.99f)
        {
            direction = Vector3.right;
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);        
        } 


    
/*
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
        */
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
        Time.timeScale = 0; // Pauzeer het spel
        EndUI.SetActive(true); // Activeer de End UI
    }
}