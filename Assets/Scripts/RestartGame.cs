using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    } 
}
