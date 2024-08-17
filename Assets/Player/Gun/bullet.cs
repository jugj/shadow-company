using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 6;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
