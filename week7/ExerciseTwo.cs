using JetBrains.Annotations;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class week7Bloquedos : MonoBehaviour
{

    public List <string> inventary = new List<string> ();

    string[] enemigo = new string[4];
    void Start()
    {
        enemigo[0] = "Serpiente";
        enemigo[1] = "Oruga";
        enemigo[2] = "Dragon";
        enemigo[3] = "UltiPersona";

        inventario();

        inventary.Add("Keys");
        inventary.Add("Green Dimonds");
        inventary.Add("Red Dimonds");
        inventary.Add("Sword");
    }


    public void enemyFind()
    {
        int i = 0;
        while (i < enemigo.Length)
        {
            Debug.Log(enemigo[i]);
            if (enemigo[i] == "Dragon")
            {
                Debug.Log("el enemigo Dragone esta en el indice" + i);
            }
            i++;
        }
    }

    public void inventario()
    {
        {
            //LLAMAR AL INDICE PARA IMPRIMIRLOS A TODOS = "show inventory " + inventary[2]
            //Debug.Log( inventary[0], inventary[1], inventary[2]);
            Debug.Log(item);
            i++;


            


            //item si el indice es 0 entonces debugeo el inventory[0], si 


        }
    }


    /*void Update()
    {

    }*/
}

