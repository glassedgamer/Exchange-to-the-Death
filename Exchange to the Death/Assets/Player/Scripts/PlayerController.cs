using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header("Objects")]
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;

    Vector2 movement;
    
    [Header("Floats")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 2f;

    private float inputX;

    bool isGrounded;
    bool facingRight = true;
    bool onnn;

    [Header("Jumping")]
    [SerializeField] Transform groundCheck;
    [SerializeField] float checkRadius;
    [SerializeField] LayerMask whatIsGround;

    void Start() {
    }

    void Update() {
        movement = new Vector2(inputX * moveSpeed, rb.velocity.y);
        
        rb.velocity = movement;
        
        if(movement != Vector2.zero && isGrounded) {
            animator.SetBool("isWalking", true);
        } else if(movement == Vector2.zero){
            animator.SetBool("isWalking", false);
        } 

        if(facingRight == false && inputX > 0) {
            Flip();
        } else if(facingRight == true && inputX < 0) {
            Flip();
        }

    }

    void FixedUpdate() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    
    void Flip() {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void Move(InputAction.CallbackContext context) {
        inputX = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context) {
        if(isGrounded) {
            animator.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
    }

}
