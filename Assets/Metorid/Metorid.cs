using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metorid : MonoBehaviour
{
    public float Geschwindigkeitright;
    public float Geschwindigkeitdown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*Geschwindigkeitright*Time.deltaTime,Space.World); 
        
        transform.Translate(Vector2.down*Geschwindigkeitdown*Time.deltaTime,Space.World); 
    }
}
