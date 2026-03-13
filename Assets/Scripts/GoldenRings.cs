using UnityEngine;

public class GoldenRings : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        
            PacmanMovement player = collision.gameObject.GetComponent<PacmanMovement>();
            player.goldenRings += 1;
            Destroy(gameObject);
        }
    }
}
