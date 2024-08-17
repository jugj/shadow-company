using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

public class Abfrage : MonoBehaviour
{
    private enum Raum {
        Raum1, Raum2, Raum3, Raum4, Raum5
    }

    public GameObject Player;
    private Raum raum = Raum.Raum1;
    int Level = 1;
    public GameObject enemyPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SpawnEnemy(float x, float y) {
        Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Monster = GameObject.FindGameObjectsWithTag("Monster");

        if (Monster.Length == 0) {
            Player.transform.position = new Vector3(0, 0, 0);

            switch (raum) {
                case Raum.Raum1:
                    SpawnEnemy(-1, 0);
                    break;
            }
        }

        //if(Monster.Length ==0){

        //    Player.transform.position = new Vector2()
            

           
        //switch(Raum){

        //case "Raum_1":

        //switch(Level)

        //case 1:

        //Instantiate(GameObject.Find("Slime"),new Vector2(-16, 5));


        //break;

        //case constant-expression2 :

        //statement(s);

        //break;

        //default :

        //statement(s);

        }
}
