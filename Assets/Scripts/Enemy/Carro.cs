using UnityEngine;

public class Carro : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float detectionRange = 5f;
    [SerializeField] Rigidbody2D rigidbody2d;

    void Update()
    {
        if (IsPlayerInRange())
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
      
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    bool IsPlayerInRange()
    {
       
        return Vector2.Distance(transform.position, player.position) < detectionRange;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
    }
}