using System;
using UnityEngine;

public class ExerciseTwo : MonoBehaviour
{
    //Open Treasure chest
    public bool hasKey;
    public bool spaceAvailable;
    bool validation;

    void Start()
    {

    }

    void Update()
    {
        if (hasKey && spaceAvailable)
        {
            validation = true;
            Debug.Log("Unlocked! ");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}