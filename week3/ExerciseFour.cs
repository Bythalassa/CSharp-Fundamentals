using System;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    //Dependencies verification

    int level = 1;
    bool hasSword;
    bool hasFireSpell;
    bool isCursed;


    bool enterDungeon;

    void Start()
    {
        bool condition1 = level >= 15;
        bool condition2 = hasSword == true || hasFireSpell == true;
        bool condition3 = isCursed == false;


        bool result = condition1 && condition2 && condition3;

        Debug.Log(result);
        print("You made it to the Dungeon ");
    }

    void Update()
    {   

    }
}
