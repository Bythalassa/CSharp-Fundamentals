using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class W5PracticalB3 : MonoBehaviour
{
    //Block 3 : Operators Management without bucles

    int[] numbers = new int[3];

    [SerializeField] private List<string> colores = new List<string>();

    void Start()
    {

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        HigherI();
        equalityVerification();
        replaceValues();
        HigherIv2();

    }

    void Update()
    {

    }

    void HigherI()
    {
        //muestra cual es el mayor entre posicion 0 y la 1
        string HigherI = numbers[0] > numbers[2] ? "Index 0 is the highest value" : "Index 1 is the highest value";
        print(HigherI);
    }

    void equalityVerification()
    {
        //verifica si el primer y último elemento del array son iguales
        string equalityVerification = numbers[0] == numbers[numbers.Length - 1] ? "The first and last element are equal values." : "The first and last element are different values.";
        print(equalityVerification);
    }

    void replaceValues()
    {
        //Intercambia los valores de la posicion 0 y la posicion 2 del array
        int temp = numbers[0];
        numbers[0] = numbers[2];
        numbers[2] = temp;
        print("Values at positions 0 and 2 have been swapped to " + numbers[0] + " and " + numbers[2]);
    }

    void HigherIv2()
    {
        //en-desarrollo
        //muestra cual es el mayor entre posicion 0 y la 1
        string HigherIv2 = numbers[0] > numbers[2] ? "Index 0 is the highest value" : "Index 1 is the highest value";
        print(HigherIv2);
    }



}
