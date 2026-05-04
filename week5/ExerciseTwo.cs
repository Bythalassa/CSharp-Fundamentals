using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class W5PracticalB3 : MonoBehaviour
{
    //Block 3 : Operators Management without bucles

    int[] numbers = new int[3];

    [SerializeField] private List<string> CreaturesNames = new List<string>();

    [SerializeField] private List<string> names = new List<string>();


    void Start()
    {

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        HigherI();
        equalityVerification();
        replaceValues();

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
        //verifica si el primer y último elemento del array son iguales
        string equalityVerification = numbers[0] == numbers[numbers.Length - 1] ? "The first and last element are equal values." : "The first and last element are different values.";
        print(equalityVerification);
    }

}
