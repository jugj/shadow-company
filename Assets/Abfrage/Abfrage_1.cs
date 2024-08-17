using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

public class Abfrage : MonoBehaviour
{
    public GameObject Player;
    string Raum = "Raum_1";
    int Level = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Monster = GameObject.FindGameObjectsWithTag("Monster");

        if(Monster.Length ==0){

            Player.transform.position = new Vector2()

        
{}      
        switch(Raum){

        case "Raum_1":

        switch(Level)

        case 1:

        Instantiate(GameObject.Find("Slime"),new Vector2(-16, 5));


        break;

        case constant-expression2 :

        statement(s);

        break;

        default :

        statement(s);

}


        }
    }
}
