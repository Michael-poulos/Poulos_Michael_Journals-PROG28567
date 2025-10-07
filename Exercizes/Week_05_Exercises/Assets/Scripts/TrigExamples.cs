using UnityEngine;

public class TrigExamples : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.DrawLine(Vector2.zero, mousePosInWorld, Color.red);

        float angle = Mathf.Atan2(mousePosInWorld.y, mousePosInWorld.x);
        //float angle = Mathf.Atan2(mousePosInWorld.y, mousePosInWorld.x);

        Debug.Log($"<color=yellow><size=16>{angle}</size></color>");
    }
}
