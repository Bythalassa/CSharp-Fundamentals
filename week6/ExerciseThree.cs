using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;
using static cicloUno;
using static UnityEditor.Progress;

public class cicloUno : MonoBehaviour
{ //block 3
    string[] score = new string[4];
    int[] damageImpact = new int[4];
    string[] swords = new string[3];

    [Serializable] public class Enemy
    {
        public string name;
        public int health;
    }

    public List<Enemy> enemies = new List<Enemy>();


    void Start()
    {
        score[0] = "20 Points";
        score[1] = "45 Points";
        score[2] = "20 Points";
        score[3] = "1020 Points";

        damageImpact[0] = 100;
        damageImpact[1] = 80;
        damageImpact[2] = 40;
        damageImpact[3] = 15;

        enemies.Add(propertiesSkullomats()); 
        enemies.Add(propertiesWretchedWitches()); 
        enemies.Add(propertiesWretchedThugs()); 
        enemies.Add(propertiesMegaera());

        swords[0] = "blue Sword";
        swords[1] = "Legendary Sword";
        swords[2] = "Boss Sword";

        numberedInventory();
    }

    public void showScore()
    {
        int i = 0;
        while (i < score.Length)
        {
            Debug.Log(score[i]);
            i++;
        }
    }
    
    public void calculateTotalDamage()
    {
        int i = 0;
        int a = 40; //daño total recibido

        do
        {
            a = a + damageImpact[i];  
            Debug.Log("total damage is " + a);
            i++;
        }
        while (i < damageImpact.Length);
    }
    Enemy propertiesSkullomats()
    {
        Enemy enemy = new Enemy { name = "Skullomats", health = 30 };
        return enemy;
    }

    Enemy propertiesWretchedWitches()
    {
        Enemy enemy = new Enemy { name = "Wretched Witches", health = 55 };
        return enemy;
    }

    Enemy propertiesWretchedThugs()
    {
        Enemy enemy = new Enemy { name = "Wretched Thugs", health = 0 };
        return enemy;
    }

    Enemy propertiesMegaera()
    {
        Enemy enemy = new Enemy { name = "Megaera", health = 0 };
        return enemy;
    }
    public void showAliveEnemy()
    {
        int i = 0;

        while (i < enemies.Count)
        {
            if (enemies[i].health > 0)
            {
                Debug.Log(enemies[i].name);
            }
            i++;
        }
    }

    /*El while controla cuántas veces iteras → tiene que ser i < enemies.Count
     El if controla qué se muestra → ahí va el filtro health > 0
     es imporante recorrer toda la lista para no cortar a enemigos vivos nombrados luego de 1 muerto (enemyHealth = 0). */
    public void findWeirdItem()
    {
        int a = 0;
        do
        {
            if (swords[a] != "Legendary Sword")
            {
                Debug.Log(swords[a] + " is not a fit ");
            }
            else
            {
                Debug.Log("found " + swords[a]);
            }
                a++;
        }
        while (a < swords.Length);
    }


    public void numberedInventory()
    {
        int a = 0;
        do
        {
            Debug.Log(swords[a] + " (" + a + ")");

            a++;
        }
        while (a < swords.Length);
    }



}





