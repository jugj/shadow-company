using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorit : MonoBehaviour
{
    public float GeschwindigkeitRight;
    public float GeschwindigkeitDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*GeschwindigkeitRight*Time.deltaTime, Space.World);
        transform.Translate(Vector2.down*GeschwindigkeitDown*Time.deltaTime, Space.World);
    }
}
