using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public enum Status 
{
    dead,
    Alive,
    Defeat,
}

//Coffe Code 
[Serializable]
public struct Entity 
{
    public string EntityName;
    public Status myStatus;

    public Entity(string entityName, Status status)
    {
        EntityName = entityName;
        this.myStatus = status;
    }
}

public class cicloUno : MonoBehaviour
{
    // Bucles y Métodos

    string[] items = new string[5];
    public List<Entity> entities = new();

    void Start()
    {
        isAlive();


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




    }


}




