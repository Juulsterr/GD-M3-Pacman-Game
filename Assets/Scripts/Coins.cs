using UnityEngine;

public class Coins : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        
            PacmanMovement player = collision.gameObject.GetComponent<PacmanMovement>();
            player.coins += 1;
            Destroy(gameObject);
        }
    }
    }