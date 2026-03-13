using Unity.Mathematics;
using UnityEngine;

public class FPSTest : MonoBehaviour
{

public class Example : MonoBehaviour
{
    GUIStyle style;

    void Start()
    {
        style = new GUIStyle();
        style.fontSize = 40;    // + grootte van de tekst
        style.normal.textColor = Color.white;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 100), "Hallo!", style);
    }
}
 void OnGUI()
    {
        float fps = 1.0f / Time.deltaTime;
        GUI.Label(new Rect(10, 10, 100, 20), "FPS: " +  math.round(fps));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
}
