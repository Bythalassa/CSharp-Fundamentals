//bloque 3

using UnityEngine;
using System.Collections.Generic;
using System;


//Coffe Code
public enum Status
{
    None,//0
    Alive,
    Defeat,
}

//Coffe Code 
[Serializable]
public struct Entity
{
    public string EntityName;
    public Status myStatus;

    public Entity(string entityName , Status status)
    {
        EntityName = entityName;
        this.myStatus = status;   
    }
}

public class blobk3 : MonoBehaviour
{
    public List<Entity> entities = new(); //Public Personalized List (create enemies in inspector + asign the stattus)
    //lista de tipo Entity
    string[] keyNames = new string[5];

    void Start()

    {

        ignoreEven();
    }

    void Update()
    {


    }


    private void EnemiesDefeated()  //*Saltar enemigos derrotados
    {
        foreach (Entity enemy in entities)
        {
            if (enemy.myStatus == Status.Defeat)
                continue;

            Debug.Log(enemy.EntityName); // ← Log del enemigo actual, no de la lista
        }
    }


    private void findKey() //find the word blueKey
    {
        keyNames[0] = "yellowKey";
        keyNames[1] = "redKey";
        keyNames[2] = "blueKey";
        keyNames[3] = "noKey";
        keyNames[4] = "vielleichtKey";

        foreach (string keyName in keyNames)
        {
            if (keyName == "blueKey")
                break;

            Debug.Log(keyName); //Debugeas der i und i ist genau was du richting als name gestellt hast, dorthin. 
        }
    }

    //ignora numeros pares
    private void ignoreEven()
    {


        for (int i = 0; i <= 20; i++) //define variable - define condicion - was ist zu der variable passiert 
            if (i % 2 == 0)
            {
                print(i + " es par");
            }
        }


    }



