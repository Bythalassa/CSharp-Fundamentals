using System;
using UnityEngine;

public class ExerciseOne : MonoBehaviour
//  basic points system

{
    
    int bulletsRed = 4;
    int bulletsGreen = 5;
    int useBulletsGreen = 2;
    int bulletsMega;
    int bulletsRecharge = 10;   

void Start()
{
    /* sum    */
    bulletsRed++;
    bulletsMega += bulletsRed + bulletsGreen;

    /* resta    */
    bulletsGreen--;
    bulletsRecarga -= useBulletsGreen - bulletsGreen;

    Debug.Log(bulletsMega);
    print("bulletsMega");

    Debug.Log(bulletsRecarga);
    print("bulletsRecharge");
}
    void Update()
    {
  
    }









}

