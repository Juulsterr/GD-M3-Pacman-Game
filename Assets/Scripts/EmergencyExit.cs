using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmergencyExit : MonoBehaviour
{
    [Tooltip("How fast the exit spins once unlocked (degrees per second).")]
    public float timer = 0f;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        // Remember the starting transform so we can restore it when the scene reloads.
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        // Reset collected state when the level starts.
        PacmanMovement.goldenRings = 0;
        GoldenRings.goldenRingsRequired = 4;
    }

    void Update()
    {
        // Rotate the exit when the player has collected 4 rings.
        if (PacmanMovement.goldenRings >= 4)
        {
            Quaternion mijnRotatie = transform.rotation;
            Quaternion doelRotatie = Quaternion.Euler(0f, 0f, -90f);
            timer += Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(mijnRotatie, doelRotatie,timer);

        }
    }

    public void Herlaad()
    {
        // Reloading the scene also resets the exit to its normal position.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
