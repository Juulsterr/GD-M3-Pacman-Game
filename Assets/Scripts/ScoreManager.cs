using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    public static void AddScore(int amount)
    {
        score += amount;
    }
}