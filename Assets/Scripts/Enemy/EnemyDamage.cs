using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float vida =3;
    //[SerializeField] private GameObject efectoMuerte;
    // Start is called before the first frame update
    public void TomarDanio(float danio)
    {
        vida -= danio;
        if (vida <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        //Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
