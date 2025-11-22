using UnityEngine;

public class tri : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += 1;
        transform.position = temp;
        

    }
}
