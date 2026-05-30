using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class cicloUno : MonoBehaviour
{

    //block 3
    string[] score = new string[4];

    void Start()
    {
        score[0] = "20 Points";
        score[1] = "45 Points";
        score[2] = "20 Points";
        score[3] = "1020 Points";

    }


    public void showScore()
    {
        int i = 0;
        while (i < score.Length)
        {
            Debug.Log(score[i]);
        }
    }
    /*
    public void calculateTotalDamage();
    {
        {

        }
    }

    public void showAliveEnemiges()
    {
        {
          
        }
    }


    public void findWeirdItem()
    {
        {

        }
    }

    public void numberedInventory()
    {
        {

        }
    }

    */

}

