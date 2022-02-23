using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyIfTrigger : MonoBehaviour
{
    [SerializeField]
    private int Score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Circle")
        {
            Score++;
            Destroy(collision.gameObject);
        }
    }

    [SerializeField]
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 100;
        GUI.TextArea(new Rect(0, 0, 100, 100), "Score: " + Score, myStyle);
    }
}
