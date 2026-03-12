using UnityEngine;

public class Beveiliging : MonoBehaviour
{
    public float speed = 2f;

    private Vector2 direction = Vector2.right; // start richting
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow)) direction = Vector2.down;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
        }
    }
    //ehy

    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}
