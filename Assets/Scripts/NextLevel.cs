using UnityEngine;

public class NextLevel : MonoBehaviour
{
   public string nextLevelSceneName;
     public void LoadNextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelSceneName);
        Time.timeScale = 1;
    }
    private void Update()
    {
        Debug.Log("Fire2: " + Input.GetButtonDown("Fire2"));
       if (Input.GetButtonDown("Fire2"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelSceneName);
            Time.timeScale = 1;
        }
    }
}
