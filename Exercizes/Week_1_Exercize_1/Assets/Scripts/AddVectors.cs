using UnityEngine;

public class AddVectors : MonoBehaviour
{
    public Transform redTransform;
    public Transform blueTransform;

    void Update()
    {
        // Exercise: Visualizing Vector Addition
        // Create a new Vector2 called "rPlusB" which adds rTransform's position to bTransform's position.​

        Vector2 rTransform = new Vector2(0, 1);
        Vector2 bTransform = new Vector2(1, 7);
        Vector2 rPlusB = rTransform + bTransform;

        if (Input.GetKeyDown("B"))
        {
            Debug.DrawLine(transform.position, bTransform, Color.blue);
        }
        if (Input.GetKeyDown("R"))
        {
            Debug.DrawLine(transform.position, bTransform, Color.red);
        }
        if (Input.GetKeyDown("R+B"))
        {
            Debug.DrawLine(transform.position, bTransform, Color.magenta);
        }



        // When the B key is held down, draw a blue line from the origin to bTransform's position.​
        // When the R key is held down, draw a red line from the origin to rTransform's position.​
        // When the R and B keys are both held down, draw a magenta from the origin to rPlusB.​

        // Exercise: Calculating Magnitude
        // Calculate the magnitude of bPlusR using the mathematical formula for calculating the length of a vector – Pythagorean Theroem.​
        // Output the magnitude to the console using either Debug.Log or print.



    }
}
