using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    public int health = 20;
    public int damage = 10;
    private int weaponcooldown;
    [SerializeField] private ParticleSystem BloodParticles;

    private ParticleSystem BloodParticlesInstance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        SpawnBloodParticles();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( weaponcooldown <= 0)
        {
        Player player = collision.GetComponent<Player>();
        player.TakeDamage(damage);
        weaponcooldown = 30;
        }
    }
    private void SpawnBloodParticles()
    {
        BloodParticlesInstance = Instantiate(BloodParticles, transform.position, Quaternion.identity);
    }
    private void FixedUpdate()
    {
        weaponcooldown--;
    }
}
