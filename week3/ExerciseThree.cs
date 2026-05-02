using System;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    //string and char concatenation

    char cantidad = '2';
    string mensaje = "Zombie Dinamita cerca";

    void Start()
    {
        string total = mensaje + cantidad;

        Debug.Log(total);
        print("total");

    }
    void Update()
    {
        
    }
}