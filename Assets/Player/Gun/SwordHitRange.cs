using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitRange : MonoBehaviour
{
    public int damage = 20;
    private int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 35)
            {
            Destroy(gameObject);
            }
    }
     void OnTriggerExit2D(Collider2D collision)  
    {
            Damaging gegner = collision.GetComponent<Damaging>();
            if (timer >= 33)
            {
            Destroy(gameObject);
            if(gegner != null)gegner.TakeDamage(damage);
            }
    }
    private void FixedUpdate()
    {
        timer++;
    }
}

