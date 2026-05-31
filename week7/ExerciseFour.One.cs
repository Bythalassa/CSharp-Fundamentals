using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Progress;

public class enemySpawner : MonoBehaviour
{ //block 4

    public List<GameObject> enemigos = new List<GameObject>();

    void Start()
    {

        enemigos.Add(GameObject.Find("enemigoBasico"));
        enemigos.Add(GameObject.Find("enemyTank"));
        enemigos.Add(GameObject.Find("enemyDPS"));

        wavesGenerator();
    }

    public void wavesGenerator()
    {
        bool waveOneSpawned = false;
        bool waveTwoSpawned = false;
        bool waveThreeSpawned = false;

        int i = 0;

        while (i == 0)
        {

            Debug.Log(enemigos[0].name);
            Debug.Log(enemigos[0].name);
            Debug.Log(enemigos[0].name);

            if (waveOneSpawned == false)
            {
                Debug.Log("Horda 1 ha aparecido");
                waveOneSpawned = true;

                i++;
            }
        }

        while (i == 1 && waveOneSpawned == true)
        {

            Debug.Log(enemigos[1].name);
            Debug.Log(enemigos[1].name);
            Debug.Log(enemigos[1].name);

            if (waveTwoSpawned == false)
            {
                Debug.Log("Horda 2 ha aparecido");
                waveTwoSpawned = true;

                i++;
            }
        }

        while (i == 2 && waveTwoSpawned == true)
        {

            Debug.Log(enemigos[2].name);
            Debug.Log(enemigos[2].name);
            Debug.Log(enemigos[2].name);

            if (waveThreeSpawned == false)
            {
                Debug.Log("Horda 3 ha aparecido");
                waveThreeSpawned = true;

                i++;
            }
        }

    }




}





