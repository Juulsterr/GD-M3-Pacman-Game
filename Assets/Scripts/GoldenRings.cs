using UnityEngine;

public class GoldenRings : MonoBehaviour
{
   public int goldenRings = 0;
    public static int goldenRingsRequired = 4;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            PacmanMovement player = collision.gameObject.GetComponent<PacmanMovement>();
            PacmanMovement.goldenRings += 1;
            ScoreManager.AddScore(10);
            Destroy(gameObject);
            goldenRingsRequired -= 1;
        }
    }
}
