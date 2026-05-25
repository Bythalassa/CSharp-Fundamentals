using UnityEngine;
using System.Collections.Generic;
using System;


//Coffe Code
public enum Status // ENUM es un tipo de valor, que contiene variables constantes. 
{
    None,//0
    Alive,
    Defeat,
}

//Coffe Code 
[Serializable]
public struct Entity // otro valor que contiene constantes campos, métodos, etc
{
    public string EntityName;
    public Status myStatus;

    public Entity(string entityName, Status status)
    {
        EntityName = entityName;
        this.myStatus = status;
    }
}

public class W8b3 : MonoBehaviour
{
    public List<Entity> entities = new(); //Public Personalized List (create enemies in inspector + asign the stattus)
    //lista de tipo Entity

    string[] keyNames = new string[5];

    void Start()
    {
        stopCriticE();
    }

    void Update(){}

    private void EnemiesDefeated()  //*Saltar enemigos derrotados
    {
        foreach (Entity enemy in entities)
        {
            if (enemy.myStatus == Status.Defeat)
                continue;

            Debug.Log(enemy.EntityName); 
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

            Debug.Log(keyName + "    searching ... "); 
        }
    }

    private void ignoreEven()     //ignora numeros pares

    {
        for (int i = 0; i <= 20; i++) 
            if (i % 2 == 0)
            {
                print(i + " es par");
            }
    }

    private void stopCriticE()     //Detener energía crítica

    {
        for (int i = 12; i >= 0; i--)
            {
                print( " Energia reducida a " + i);
            }
    }




    //Detectar jefe final





}



