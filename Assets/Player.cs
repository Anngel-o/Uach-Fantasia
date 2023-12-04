using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.D)))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
        if ((Input.GetKey(KeyCode.A)))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
    }

}
