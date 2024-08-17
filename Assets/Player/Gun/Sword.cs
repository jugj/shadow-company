using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private int weaponcooldown = 0;
    public Transform swordPoint;
    public GameObject SwordHitRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && weaponcooldown <= 0)
        {
            Instantiate(SwordHitRange, swordPoint.position, transform.rotation );
            weaponcooldown = 40;
        }
    }
    private void FixedUpdate()
    {
        weaponcooldown--;
    }
}
