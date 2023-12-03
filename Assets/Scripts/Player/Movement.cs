using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    [Range(10, 30)] public int velocidad = 10;
    [Range(1, 15)] public float saltoFuerza = 5;
    private bool isGrounded;
    private int jumpsRemaining = 2;
    public SpriteRenderer PlayerRenderer;
    private BoxCollider2D boxCollider2D;
    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Enemy").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");
        rbPlayer.velocity = new Vector2(movimiento * velocidad, rbPlayer.velocity.y);
        if (movimiento > 0 )
        {
            PlayerRenderer.flipX = false;   
        }
        else if (movimiento <0 )
        {
            PlayerRenderer.flipX=true;
        }

        if (isGrounded)
        {
            jumpsRemaining = 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpsRemaining > 0)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, 0);
            rbPlayer.AddForce(Vector2.up * saltoFuerza, ForceMode2D.Impulse);
            jumpsRemaining--;
            if (jumpsRemaining == 1)
            {
                animator.SetTrigger("Salto");
            }
            
            else if (jumpsRemaining == 0)
            {
                animator.SetTrigger("DobleSalto");
            }

        }

        float rotationAngle = transform.rotation.eulerAngles.x;
        boxCollider2D.transform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
       

    }
    private void OnCollisionEnter2D(Collision2D cther)
    {
        if (cther.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    
}
