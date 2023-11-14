using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerTrigger : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Transform weaponSpawnL;
    public Transform weaponSpawnR;
    public GameObject weaponD;
    public GameObject weaponI;
    private Vector2 playerDirection;
    private int weaponSpeed;
    float horizontalInput = -1;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput -= 1;
        }
                
   

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet(horizontalInput);
        }


    }



    private void FireBullet(float horizontal)
    {
        if (horizontal > 0)
        {
            Instantiate(weaponD, weaponSpawnL.position, weaponSpawnL.rotation);
        }
        else if (horizontal < 0)
        {
            Instantiate(weaponI, weaponSpawnL.position, weaponSpawnL.rotation);
        }
    }

    private void FireBulletI()
    {
        Instantiate(weaponI, weaponSpawnL.position, weaponSpawnL.rotation);
    }
}
