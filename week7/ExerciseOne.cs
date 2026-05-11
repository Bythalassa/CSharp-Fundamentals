using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class week7Bloque1 : MonoBehaviour
{
    //public List<string> numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    public List<string> opcion = new List<string>() { "0", "1", "2", "3", "4", "5" };


    void Start()
    {
        menuSimple();

    }

   /* public void ascendantCounter()
    {
        int i = 0;
        while (i < numbers.Count)
        {
            Debug.Log(numbers[i]);

            if (i < numbers.Count)
            {
                //recorre tods los indices e imprime su numero
                Debug.Log("The number is " + i);
                i++;
            }
        }
    }*/

    public void descendantCounter()
    {
        int baseNumber = 20;

        while (baseNumber > 0)
        {
            Debug.Log("Descedant count in : " + baseNumber);
            baseNumber--;
        }
    }

    public void printMessage()
    {
        int messageNumber = 5;

        do
        {
            Debug.Log("Jugador conectado ");
            messageNumber--;
        }
        while (messageNumber > 0);

    }


    public void playerlife()
    {
        int lifeNumber = 100;

        while (lifeNumber > 0)
        {
            Debug.Log("Energy points : " + lifeNumber);
            lifeNumber--;
        }
    }

    public void menuSimple()
    {
        int i=0;
        do
        {
            Debug.Log(opcion[i]);
            if (opcion[i] == "1")
                Debug.Log("Presiona 1");
            i++;
        }
       
        while (i < opcion.Count);

    }

    //primer menu simple

    void Update()
    {
    }
}
   
    

