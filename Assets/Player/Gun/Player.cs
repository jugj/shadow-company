using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

<<<<<<< HEAD:Assets/Player/Gun/Player.cs
public class Player : MonoBehaviour
=======
public class PlayerMovment : MonoBehaviour
>>>>>>> 7085259a3dc79982c3d5b218fa09f43144ad9aee:Assets/Player/Gun/Player Movment.cs
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
<<<<<<< Updated upstream
      var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

      transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg, Vector3.forward); 
      if (Input.GetKey("w")) {
        float speed = Geschwindigkeit * Time.deltaTime;
        Debug.Log("magnitude: " + (dir.magnitude) + " speed: " + speed);
        if (dir.magnitude > speed + 10) transform.Translate(Vector2.right * speed);
      //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
      //if (Input.GetKey("w"))
      //{
      //  transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime);
      //}
=======
      if (Input.GetKey("w"))
      {
        transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime);
      }
      var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position); 
      var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
>>>>>>> Stashed changes
      
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
