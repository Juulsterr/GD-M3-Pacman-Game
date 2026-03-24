using UnityEngine;

public class Entrance : MonoBehaviour
{
     private Vector3 initialPosition;
    private Quaternion initialRotation;

    public GameObject doorLeft;
    public GameObject doorRight;
    public float openAngle = 90f;
    public float openDuration = 0.5f;

    private bool doorsOpened;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!doorsOpened && collision.gameObject.CompareTag("Player"))
        {
            doorsOpened = true;
            StartCoroutine(OpenDoors());
        }
    }

    private System.Collections.IEnumerator OpenDoors()
    {
        float elapsed = 0f;
        Quaternion startLeft = doorLeft.transform.rotation;
        Quaternion startRight = doorRight.transform.rotation;
        Quaternion targetLeft = startLeft * Quaternion.Euler(0f, 0f, -openAngle);
        Quaternion targetRight = startRight * Quaternion.Euler(0f, 0f, openAngle);

        while (elapsed < openDuration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / openDuration);
            doorLeft.transform.rotation = Quaternion.Slerp(startLeft, targetLeft, t);
            doorRight.transform.rotation = Quaternion.Slerp(startRight, targetRight, t);
            yield return null;
        }

        doorLeft.transform.rotation = targetLeft;
        doorRight.transform.rotation = targetRight;
    }
}
