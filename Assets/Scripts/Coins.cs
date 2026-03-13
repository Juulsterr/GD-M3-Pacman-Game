using UnityEngine;

public class Coins : MonoBehaviour
{
    
    public static event System.Action<int> OnScoreChange;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        
            PacmanMovement player = collision.gameObject.GetComponent<PacmanMovement>();
            player.coins += 1;
            ScoreManager.AddScore(1);
            Destroy(gameObject);
        }
    }
    }