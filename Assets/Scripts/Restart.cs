using UnityEngine;

public class Restart : MonoBehaviour
{
     private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // Reload the current scene
    }
    void restartLevel()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            Die();
        }
    }
}
