using JetBrains.Annotations;
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
    float horizontalInput = -1;
    public Animator animator;
    public BarAttack barAttack;

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
                
   

        if (Input.GetButtonDown("Fire1") && barAttack.CurrentAttack > 0.0f)
        {
            barAttack.subAttack();
            FireBullet(horizontalInput);
        }

        
    }

    private void ResetAttackStatus()
    {
        animator.SetBool("EstaAtacando", false);
    }

    private void FireBullet(float horizontal)
    {
        animator.SetTrigger("Atacar");
        //animator.SetBool("EstaAtacando", true);
        if (horizontal > 0)
        {
            Instantiate(weaponD, weaponSpawnL.position, weaponSpawnL.rotation);
        }
        else if (horizontal < 0)
        {
            Instantiate(weaponI, weaponSpawnL.position, weaponSpawnL.rotation);
        }
        //Invoke("ResetAttackStatus", 1f);
    }

    private void FireBulletI()
    {
        Instantiate(weaponI, weaponSpawnL.position, weaponSpawnL.rotation);
    }
}
