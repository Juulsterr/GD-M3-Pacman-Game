using UnityEngine;
using System.Collections;

public class Timer: MonoBehaviour {

public float targetTime = 120.0f;

public void Update(){

targetTime -= Time.deltaTime;

if (targetTime <= 0.0f)
{
   timerEnded();
}

}
 private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // Reload the current scene
    }

public void timerEnded()
    {
        Die();
        // Hier kun je ook andere acties uitvoeren, zoals het tonen van een game over scherm of het resetten van de score.
    }


}