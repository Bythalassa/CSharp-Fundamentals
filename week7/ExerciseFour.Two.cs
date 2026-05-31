using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Progress;

public class playerAttacks : MonoBehaviour
{ //block 4

    //player has spawned en la mazamorra 1
    //si la horda 1 has spawned entonces horda 1 esta viva
    //El player ataca horda 1 
    //si el player ataca horda 1 esa muerta 
    // desbloqueo de puerta 2
    //**repetir para horda 2 y 3**


    public List<string> salas = new List<string>();

    void Start()
    {
        salas.Add("salaUno");
        salas.Add("salaDos");
        salas.Add("salaTres");

        playerAttack();
    }

    public void playerAttack()
    {
        bool playerSpawned = false;
        bool playerAttack = false;

        bool hordaUnoViva = false;
        bool hordaDosViva = false;
        bool hordaTresViva = false;

        bool hordaUnoDead = false;
        bool hordaDosDead = false;
        bool hordaTresDead = false;

        bool doorTwoUnlocked = false;
        bool doorThreeUnlocked = false;

        int i = 0;

        while (i == 0)
        {
            playerSpawned = true;
            Debug.Log("Player has spawned in " + salas[0]);
            // verificar que la horda a spawneado --- 


            if (waveOneSpawned == false)
            {
                Debug.Log("Horda 1 ha aparecido");
                waveOneSpawned = true;

                i++;
            }
        }

        while (i == 1 && waveOneSpawned == true)
        {

            Debug.Log(salas[1]);
            Debug.Log(salas[1]);
            Debug.Log(salas[1]);

            if (waveTwoSpawned == false)
            {
                Debug.Log("Horda 2 ha aparecido");
                waveTwoSpawned = true;

                i++;
            }
        }

        while (i == 2 && waveTwoSpawned == true)
        {
            Debug.Log(salas[2]);
            Debug.Log(salas[2]);
            Debug.Log(salas[2]);

            if (waveThreeSpawned == false)
            {
                Debug.Log("Horda 3 ha aparecido");
                waveThreeSpawned = true;

                i++;
            }
        }

    }




}





