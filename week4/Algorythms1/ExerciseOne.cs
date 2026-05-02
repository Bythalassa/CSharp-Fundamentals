using System;
using Unity.VisualScripting;
using UnityEngine;

public class ExerciseOne : MonoBehaviour
{
    //Energy system

    int liveEnergy = 20;
    int abilityCost = 10;
    int totalAbility;

    void Start()
    {
        totalAbility = liveEnergy - abilityCost;
        Debug.Log(totalAbility);
    }


    void Update()
    {

    }
}