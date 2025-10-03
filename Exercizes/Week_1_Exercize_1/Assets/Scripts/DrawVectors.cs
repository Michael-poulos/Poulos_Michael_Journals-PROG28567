using UnityEngine;

public class DrawVectors : MonoBehaviour
{
    void Update()
    {
        // Create two Vector2 variables, "dVector" and "eVector"
        // Set their values to dVector: (0, 1) and eVector: (3, -2)

        Vector2 dVector = new Vector2(0,1);
        Vector2 eVector = new Vector2(3,-2);

        Debug.DrawLine(transform.position,eVector,Color.yellow);
        Debug.DrawLine(transform.position, dVector, Color.grey);

        // Use Debug.DrawLine to draw a yellow vector starting at the origin and ending at dVector.
        // Use Debug.DrawLine to draw a grey vector starting at the origin and ending at eVector.
    }
}
