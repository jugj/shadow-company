using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitRange : MonoBehaviour
{
    public float damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
            Damaging gegner = collision.GetComponent<Damaging>();
            Destroy(gameObject);
            gegner.TakeDamage(damage);
    }
}

