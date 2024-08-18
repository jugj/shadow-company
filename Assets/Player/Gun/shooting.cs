using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public Animator GunAnimator;
    private int weaponcooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (weaponcooldown <= 10)
        {
        GunAnimator.SetBool("GunAnimation", false);
        }
        if (Input.GetButtonDown("Fire1") && weaponcooldown <= 0)
        {
        Instantiate(bullet, shootingPoint.position, transform.rotation );
        GunAnimator.SetBool("GunAnimation", true);
        weaponcooldown = 25;
        }
    }
    private void FixedUpdate()
    {
        weaponcooldown--;
    }
}