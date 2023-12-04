using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour
{
    public Image barHealth;
    [SerializeField] float healthCurrent;
    [SerializeField] float healthMax;

    public float CurrentAttack
    {
        get { return healthCurrent; }
    }

    void Update()
    {
        barHealth.fillAmount = healthCurrent/healthMax;
        if (healthCurrent <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    public void subHealth(){
        healthCurrent-=20;
    }

    public void addHealth(){
        healthCurrent+=20;
    }
}
