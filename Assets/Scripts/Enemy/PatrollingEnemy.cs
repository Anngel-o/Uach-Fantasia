using UnityEngine;

public class PatrollingEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed = 3f;

    private int currentPatrolIndex = 0;
    private bool isMovingForward = true;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if (patrolPoints.Length == 0)
        {
            Debug.LogError("Patrol points not set for the enemy!");
            return;
        }

       
        Vector2 target = patrolPoints[currentPatrolIndex].position;
        transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);

        
        if (transform.position.x < target.x)
        {
            spriteRenderer.flipX = false;
        }
        else
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