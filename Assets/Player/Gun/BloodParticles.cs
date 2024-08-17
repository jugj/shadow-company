using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodParticles : MonoBehaviour
{
    private int zeit = 100;
    // Start is called before the first frame update
    void Start()
    {
        zeit = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (zeit <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        zeit--;
    }
}
