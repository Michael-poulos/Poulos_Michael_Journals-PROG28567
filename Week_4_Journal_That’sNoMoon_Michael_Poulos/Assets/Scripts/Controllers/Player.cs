using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {

        // draw a 5-unit white line from the origin for 2.5 seconds
        Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.red);


        // public void EnemyRadar(float radius, int circlePoints 
        //{
        //  if ()
        //  {
        //    return ();
        //   }

        //  }
    }
}
