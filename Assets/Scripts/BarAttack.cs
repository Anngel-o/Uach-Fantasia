using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarAttack : MonoBehaviour
{
    public Image barAttack;
    [SerializeField] float attackCurrent;
    [SerializeField] float attackMax;

    public float CurrentAttack
    {
        get { return attackCurrent; }
    }

    void Update()
    {
        barAttack.fillAmount = attackCurrent/attackMax;
    }

    public void subAttack(){
        attackCurrent-=10;
    }

    public void addAttack(){
        attackCurrent+=10;
    }
}
