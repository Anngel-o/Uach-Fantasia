using UnityEngine;

public class PatrollingEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed = 3f;

    private int currentPatrolIndex = 0;
    private bool isMovingForward = true;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        Vector2 target = patrolPoints[currentPatrolIndex].position;
        Vector2 movement = (target - (Vector2)transform.position).normalized;
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);

       
        if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        if (Vector2.Distance(transform.position, target) < 0.1f)
        {
            if (isMovingForward)
            {
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            }
            else
            {
                currentPatrolIndex = (currentPatrolIndex - 1 + patrolPoints.Length) % patrolPoints.Length;
            }
        }
    }
}