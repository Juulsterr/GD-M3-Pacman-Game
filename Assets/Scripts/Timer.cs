using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float targetTime;
    public float maxTime = 120.0f; // 2 minuten

    public GameObject EndUI;
    public TextMeshProUGUI timerText;
    void Start()
    {
        targetTime = maxTime; // Start de timer op de maximale tijd
        Time.timeScale = 1; // Zorg dat de tijd normaal verloopt
    }

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
    public void timerEnded()
    {
        // Tijd is op, dus game over
        Time.timeScale = 0; // Pauzeer het spel
        EndUI.SetActive(true); // Activeer de End UI
    }
}