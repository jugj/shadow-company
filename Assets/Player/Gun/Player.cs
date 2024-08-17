using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float Geschwindigkeit = 3;
    public float health = 100;
    [SerializeField] private ParticleSystem BloodParticles;

    private ParticleSystem BloodParticlesInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey("w"))
      {
        transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime);
      }
      var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position); 
      var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
      
    }
   public void TakeDamage(float damage)
    {
        health -= damage;
        SpawnBloodParticles();
        if (health <= 0)
        {
           
            Destroy(gameObject);
        }
    }
    private void SpawnBloodParticles()
    {
        BloodParticlesInstance = Instantiate(BloodParticles, transform.position, Quaternion.identity);
    }
  


}
