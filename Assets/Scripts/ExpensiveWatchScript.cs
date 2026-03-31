using UnityEngine;

public class ExpensiveWatchScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public static int expensiveWatchesRequired = 2;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            PacmanMovement player = collision.gameObject.GetComponent<PacmanMovement>();
            PacmanMovement.expensiveWatches += 1;
            ScoreManager.AddScore(100);
            Destroy(gameObject);
            expensiveWatchesRequired -= 1;
        }
    }
}
