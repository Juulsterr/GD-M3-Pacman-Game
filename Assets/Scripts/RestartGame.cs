using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public string sceneName;
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);    } 


    private void Update()
    {

        // Debug.Log("Fire1: " + Input.GetButtonDown("Fire1"));
        // if (Input.GetButtonDown("Fire1"))
        // {
        //     UnityEngine.SceneManagement.SceneManager.LoadScene("Pacman-Alysha");   
        // }    

    }   
}
