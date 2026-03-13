using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float targetTime = 120.0f;
    public TextMeshProUGUI timerText;

    void Update()
    {
        // Timer laten aftellen maar niet onder 0 laten gaan
        targetTime = Mathf.Max(targetTime - Time.deltaTime, 0);

        // Tekst updaten met 2 decimalen
        timerText.text = "Time: " + targetTime.ToString("F2");

        // Als timer klaar is
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void timerEnded()
    {
        Time.timeScale = 0;
        StartCoroutine(WaitAndDie());
    }

    private IEnumerator WaitAndDie()
    {
        yield return new WaitForSecondsRealtime(2);
        Die();
    }
}