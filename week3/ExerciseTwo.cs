using System;
using UnityEngine;

public class ExerciseTwo : MonoBehaviour
{
    //Level Verification

    int myLevel = 2;
    int requiredLevel = 3;
    bool positiveAcess = false;

    // Mensaje de Unity | 0 referencias
    void Start()
    {
        positiveAcess = myLevel >= requiredLevel;

        Debug.Log(positiveAcess);
        print("positiveAcess");
    }

    void Update()
    {

    }
}









