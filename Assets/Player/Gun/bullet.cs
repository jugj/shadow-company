using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 6;
    public int damage = 10;

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
        if( collision.gameObject.tag.Equals("Player") == true )
        {

        }
        else
        {
            Damaging gegner = collision.GetComponent<Damaging>();
            Destroy(gameObject);
            gegner.TakeDamage(damage);
        }
    }
}
