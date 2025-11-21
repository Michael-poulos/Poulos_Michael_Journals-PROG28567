using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum FacingDirection
    {
        left, right
    }

    Rigidbody2D rb; 
    public float speed;
    public float accel;
    Vector2 velocity; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }





    void FixedUpdate()
    {
        // The input from the player needs to be determined and
        // then passed in the to the MovementUpdate which should
        // manage the actual movement of the character.

        Vector2 playerInput = new Vector2(); 
        


        playerInput.x = Input.GetAxisRaw("Horizontal");

      


        MovementUpdate(playerInput);
    }

    private void MovementUpdate(Vector2 playerInput)
    {
        // Debug.Log(playerInput); 
 

        

        if ((playerInput.x < 0 && velocity.x > -speed) || (playerInput.x > 0 && velocity.x < speed)) {
            velocity += playerInput * speed * (Time.deltaTime / accel);
        }




        rb.linearVelocity = velocity;


    }

    public bool IsWalking()
    {
        return false;
    }
    public bool IsGrounded()
    {
        return false;
    }

    public FacingDirection GetFacingDirection()
    {
        return FacingDirection.left;
    }
}
