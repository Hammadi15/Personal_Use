using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovments : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 movement;
    [SerializeField] private int speed = 5;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value){
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0){

            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }



    }
    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        /* if (movement.x != 0 || movement.y != 0)
         {
             rb.linearVelocity = movement * speed;

         }
        */
        rb.AddForce(movement * speed);
    }

}
