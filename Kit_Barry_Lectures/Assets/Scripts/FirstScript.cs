using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;

        pos.x += speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        
        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {

            speed = speed * -1;

        }
        transform.position = pos;

    }
}
