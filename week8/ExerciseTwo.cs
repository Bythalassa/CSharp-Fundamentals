using System;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;


public enum Status //Coffe Code
{
    dead,
    Alive,
    Defeat,
}

public enum State //Coffe Code mod
{
    weird,
    ok,
    mega,
}

//Coffe Code 
[Serializable]
public struct Entity //Coffe Code**rehusing 4 enum state
{
    public string EntityName;
    public Status myStatus;
    public State  myState;


    public Entity(string entityName, Status status, State state)
    {
        EntityName = entityName;
        this.myStatus = status;
        this.myState = state;
    }
}

public class cicloUno : MonoBehaviour
{
    // Bucles y Métodos

    string[] items = new string[5];
    public List<Entity> entities = new();

    void Start()
    {
        isWeird();


    }

    void Update() { }

    private void doDamage()
    {
        for (int i = 5; i >= 1; i--)
        {
            print(i + "attack");
        }

    }

    private void inventoryShow()
    {
        items[0] = "duck";
        items[1] = "potion";
        items[2] = "stick";
        items[3] = "gold";
        items[4] = "apple";

        foreach (string item in items)
        {
            print(item);
        }
    }

    private void isAlive()
    {
        foreach (Entity enemy in entities)
        {
            if (enemy.myStatus == Status.dead)
                continue;

            Debug.Log(enemy.EntityName);
        }
    }

    private void isWeird()
    {
        foreach (Entity enemy in entities)
        {
            if (enemy.myState == State.weird)
                break;

            Debug.Log(enemy.EntityName);
        }
    }

    //reto 20 fue un reto personal para jeremy no tengo dudas cambie mi 17 por 18 l;(

}




