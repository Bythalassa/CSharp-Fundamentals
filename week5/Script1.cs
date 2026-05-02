using System;
// Exercises 10-20 from lab

using JetBrains.Annotations;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Video;

public class Script1 : MonoBehaviour
{
    void Start()
    {
        ExerciseTwenty();
    }

    void Update()
    {

    }


    public void ExerciseTwenty() // Method: Evaluate Action
    {
        int health = 38;
        int mana = 100;
        bool enemyNear = true;
        bool hasPotion = false;

        string EvaluateAction(int health, int mana, bool enemyNear, bool hasPotion)
        {
            if (!enemyNear) return "Wait";

            return health <= 20 && !hasPotion ? "Run Away"
                 : health <= 40 && !hasPotion ? "Quick! Get a POTION"
                 : health <= 40 && hasPotion ? "Heal"
                 : "Attack";
        }

        /*
        if (!enemyNear)
            return "Wait";

        if (health <= 20 && !hasPotion)
            return "Run Away";

        if (health <= 40 && !hasPotion)
            return "Quick! Get a POTION";

        if (health <= 40 && hasPotion)
            return "Heal";

        return "Attack";
        }
        */

        string action = EvaluateAction(health, mana, enemyNear, hasPotion);

        Debug.Log("Player action is: " + action);
    }




    public void ExerciseNineteen() // Method: Complex classification
    {
        int score = 200;
        int deaths = 2;

        string GetRank(int score, int deaths)
        {
            return score > 300 ? score > 500 && deaths == 0 ? "S" : "A" : "B";
        }

        string rankStatus = GetRank(score, deaths);

        Debug.Log("Player rank is: " + rankStatus);
    }




    public void ExerciseEighteen() // Method with double ternary
    {
        float distance = 12.5f;
        int distanceInt = 1;

        string GetAttackType(float distance)
        {
            return distanceInt < 8 ? distanceInt < 2 ? "Melee" : "Range" : "Idle";
        }

        string attackType = GetAttackType(distance);
        Debug.Log("Attack type is: " + attackType);
    }






    public void ExerciseSeventeen() // Method: Smart door opening
    {
        bool enemyNear = true;
        int level = 6;
        bool masterKey = true;
        bool normalKey = true;
        bool openDoor = false;

        bool CanOpenDoor(bool masterKey, bool normalKey, int level, bool enemyNear)
        {
            return masterKey || (normalKey && level >= 5) ? !enemyNear ? openDoor : !openDoor : !openDoor;
        }

        bool doorState = CanOpenDoor(masterKey, normalKey, level, enemyNear);

        Debug.Log("Door state is: " + (doorState ? "Open" : "Closed"));
    }




    public void ExerciseSixteen() // Method: Player state
    {
        string GetPlayerState(int health, int stamina)
        {
            return health > 0 ? stamina > 20 ? "Ready" : "Tired" : "Dead";
        }

        int health = 1;
        int stamina = 2;

        string state = GetPlayerState(health, stamina);
        Debug.Log("Player state is: " + state);
    }




    public void ExerciseFifteen() // Enemy state 2
    {
        string state;
        bool enemyWatching = true;
        bool playerNear = false;
        bool fullEnergy = false;

        state = enemyWatching ? playerNear && fullEnergy ? "Attack" : "Chase" : "Wait";

        Debug.Log("Enemy state is: " + state);
    }





    public void ExerciseFourteen() // Damage multiplier
    {
        bool criticalAttack = true;
        bool enemyVulnerable = true;
        string attackState;

        attackState = criticalAttack ? enemyVulnerable ? "damage x2" : "damage x1.5" : "normal damage";
        Debug.Log("Your attack type is: " + attackState);
    }






    public void ExerciseThirteen() // Movement type
    {
        string movement;
        string sprint = "sprint";
        string run = "run";
        string walk = "walk";
        int stamina = 1;

        movement = stamina > 30 ? stamina > 70 ? sprint : run : walk;

        Debug.Log("Your movement type is: " + movement);
    }





    public void ExerciseTwelve() // Special zone access
    {
        string access;
        string accessGranted = "Access Granted";
        string accessDenied = "Access Denied";
        bool VIP = true;
        bool inCombat = true;
        int level = 6;

        access = level >= 10 || VIP ? !inCombat ? accessGranted : accessDenied : "Improve your level or get the VIP card!";

        Debug.Log("Special zone entry: " + access);
    }





    public void ExerciseElevenForm1() // Visual health state
    {
        string state;
        int health = 0;

        state = (health < 50) ? (health < 20) ? "critical" : "injured" : "stable";
        Debug.Log("Your state is: " + state);
    }





    public void ExerciseElevenForm2() // Visual health state - readable values from stable to critical
    {
        string state;
        int health = 0;

        state = health > 20 ? health > 50 ? "stable" : "injured" : "critical";
    }






    public void ExerciseTen() // Basic enemy AI - using nested ternaries
    {
        string state;
        bool enemyWatching = true;
        bool playerNear = false;

        state = enemyWatching ? playerNear ? "Attack" : "Chase" : "Patrol";
        Debug.Log(state);
    }




}