using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponI : MonoBehaviour
{
    private float velocidad = 10;
    public int danio = 1;
    public float life = 2;
    public SpriteRenderer playerRenderer;

    float position;
    private void Start()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>());
    }
    private void Update()
    {

        transform.Translate(Vector2.left * velocidad * Time.deltaTime);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyDamage>().TomarDanio(danio);
            Destroy(gameObject);

        }
    }

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
