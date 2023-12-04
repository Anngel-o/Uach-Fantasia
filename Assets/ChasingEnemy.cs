using UnityEngine;
public class ChasingEnemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    public float detectionRange = 5f;
    private bool isChasing = false;

    void Update()
    {
        if (IsPlayerInRange())
        {
            isChasing = true;
        }

        if (isChasing)
        {
            ChasePlayer();
        }
    }

    bool IsPlayerInRange()
    {
  
        return Vector2.Distance(transform.position, player.position) < detectionRange;
    }

    void ChasePlayer()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}