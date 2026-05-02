using System;
using UnityEngine;

public class ExerciseThree : MonoBehaviour
{
    //Player Health Status
    public int currentHealth;
    public int damageReceived;

    void Start()
    {
        currentHealth -= damageReceived;
    }

    void Update()
    {
        if (currentHealth > 31)
        {
            {
                Debug.Log("Jugador Estable");
            }
        }
        else if (currentHealth <= 30 && currentHealth > 0)
        {
            {
                Debug.Log("Jugador en Peligro");
            }
        }
        else if (currentHealth <= 0)
        {
            {
                Debug.Log("Game Over");
            }
        }
    }
}