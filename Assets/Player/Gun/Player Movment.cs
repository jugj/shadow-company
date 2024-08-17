using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovment : MonoBehaviour
{
    public float Geschwindigkeit = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
      
    }

  
  void OnTriggerEnter2D(Collider2D other)
  {
  
  }

    

}
