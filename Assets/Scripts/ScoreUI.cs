using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;
    void Start()
    {
        ScoreManager.score = 0; // Reset de score bij het starten van het spel
    }

    void Update()
    {
        scoreText.text = "Score: " + ScoreManager.score;
        
    }
}