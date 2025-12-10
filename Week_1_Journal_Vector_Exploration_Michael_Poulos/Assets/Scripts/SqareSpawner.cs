using UnityEngine;
using UnityEngine.UIElements;

public class SqareSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            return Debug.DrawLine(Vector2.zero, new Vector2 (5,7), Color.blue );
        }
    }
}
