using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public Transform bombTransform;
    public Transform ObjectiveEnd;
    public Transform ObjectiveStart; 

    public float accelerationTime, decelerationTime;
    public float maxSpeed;
    private float acceleration, deceleration;
    private Vector3 velocity;


    private void Start()
    {
        acceleration = maxSpeed / accelerationTime;
        deceleration = maxSpeed / decelerationTime;
    }


    void Update()
    {

        Vector2 distanceBetween = ObjectiveEnd.position - ObjectiveStart.position;

        Debug.DrawLine(ObjectiveStart.position, ObjectiveEnd.position, Color.red);

        Debug.Log(distanceBetween.magnitude + "M");

        Vector2 playerInput = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerInput += Vector2.up;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerInput += Vector2.down;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerInput += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerInput += Vector2.right;
        }

        if (playerInput.magnitude > 0)
        {
            velocity += (Vector3)playerInput.normalized * acceleration * Time.deltaTime;
                
            if (velocity.magnitude > maxSpeed)
                {
                    velocity = velocity.normalized * maxSpeed;
                }
        }
        else
        {
            Vector3 changeInVelocity = velocity.normalized * deceleration * Time.deltaTime;
             if (changeInVelocity.magnitude > velocity.magnitude)
             {
                    velocity = Vector3.zero;
             }
             else
             {
                    velocity -= changeInVelocity;
             }

        }

            transform.position += velocity * Time.deltaTime;
        }
    }


    
