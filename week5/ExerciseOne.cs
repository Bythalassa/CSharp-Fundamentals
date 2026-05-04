using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class W5PracticalB2 : MonoBehaviour
{
    //Block 2 : Access and direct manipulation of Array and List elements
    int[] numbers = new int[5];

    [SerializeField] private List<string> CreaturesNames = new List<string>();

    [SerializeField] private List<string> names = new List<string>();


    void Start()
    {

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        print("show first value " + numbers[0] + " and last value " + (numbers.Length - 1));
        //(numbers.Count - 1) for List
        //(numbers.Length - 1) for Array
        //.Remove does not apply to Array, only List. Use .RemoveAt() for Array.

        numbers[2] = 9;
        print("The new value of element [2] is: " + numbers[2]);


        CreaturesNames.Add("Frankestein");
        CreaturesNames.Add("Dracula");
        CreaturesNames.Add("Witch");
        CreaturesNames.Add("Skeleton");

        CreaturesNames.Remove("Witch");
        print("Live count of Creatures Names is : " +  CreaturesNames.Count);

        names.Add("Firulais");
        names.Add("Gregory");
        names.Add("Nicolas");
        names.Add("Ann");
        print("Live count of Names is : " + names.Count);



    }

    void Update()
    {
        
    }
}
