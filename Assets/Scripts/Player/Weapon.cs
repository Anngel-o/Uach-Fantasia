using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float velocidad=10;
    public int danio=1;
    public float life = 2;
    public SpriteRenderer playerRenderer;
   
    float position;

    private void Update()
    {  
      
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);


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

    public void SetSpeed(int newspeed)
    {
        this.velocidad = newspeed;
    }

}
