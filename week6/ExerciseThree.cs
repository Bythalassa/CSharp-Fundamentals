using System.Collections.Generic;
using UnityEngine;

public class W6PracticalB4 : MonoBehaviour
{

    //Block 4 : Classes (Coleccions)


    [System.Serializable] // la clase es identificada de esta manera por Unity para volver publica una lista Personalizada.
    public class Enemy
    {
        public string name;
        public int health;
    }

    public List<Enemy> enemies = new List<Enemy>();

   
    void Start()
    {
        // Cada método crea su Enemy, asigna la propiedad de nombre y vida, lo imprime y lo entrega a la lista.
        enemies.Add(propertiesSkullomats()); //a estos los matas de 1 pero son ruidosos
        enemies.Add(propertiesWretchedWitches()); //ellas tienen 1/3 más de vida pero igual faciles de matar
        enemies.Add(propertiesWretchedThugs()); //doble de vida que witches, consigue 15% de mejora en cast y ya.
        enemies.Add(propertiesMegaera()); //Boss 1, tiene vida regular, mucha más resistencia que tú al inicio.
        enemies.Add(propertiesBrimstone());//el menor de vida pero te arruina la partida si lo evitas.

        recibirDaño("Megaera", 60);
        recibirDaño("Brimstone", 22);
        print(CompareHealth(enemies[3], enemies[4]));

    }

    void Update() { }

    Enemy propertiesSkullomats()
    {
        Enemy enemy = new Enemy { name = "Skullomats", health = 30 };
        print("Enemy: " + enemy.name + ", total life: " + enemy.health);
        return enemy;
    }

    Enemy propertiesWretchedWitches()
    {
        Enemy enemy = new Enemy { name = "Wretched Witches", health = 55 };
        print("Enemy: " + enemy.name + ", total life: " + enemy.health);
        return enemy;
    }

    Enemy propertiesWretchedThugs()
    {
        Enemy enemy = new Enemy { name = "Wretched Thugs", health = 150 };
        print("Enemy: " + enemy.name + ", total life: " + enemy.health);
        return enemy;
    }

    Enemy propertiesMegaera()
    {
        Enemy enemy = new Enemy { name = "Megaera", health = 750 };
        print("Enemy: " + enemy.name + ", total life: " + enemy.health);
        return enemy;
    }

    Enemy propertiesBrimstone()
    {
        Enemy enemy = new Enemy { name = "Brimstone", health = 10 };
        print("Enemy: " + enemy.name + ", total life: " + enemy.health);
        return enemy;
    }

    void recibirDaño(string enemyName, int damage) /*parámetros se llaman desde el Start,
                                                   se le pasa el nombre del enemigo y la cantidad de daño a recibir.
                                                   mientras recibirDaño se llame, los enemigos recibiran la actualización.*/
    {
        Enemy target = enemies.Find(e => e.name == enemyName); // Busca por nombre
        /*Enemy target: Declara una variable llamada target de tipo Enemy
        .Find(...) es Método de List<T> que recorre la lista y devuelve el primer elemento que cumpla la condición dada.  
        (e => e.name == enemyName) : "dado un enemigo e, comprueba si e.name es igual a enemyName", pero yo no entiendo esto.*/
        if (target != null)
        { // != es (diferente de), es decir "si target no es nulo, entonces..."
            target.health -= damage;
            print(target.name + " received damage: " + damage + ", remaining life: " + target.health);
        }
        else
        { 
            print("Enemy '" + enemyName + "' not found.");
        }
    }

    string CompareHealth(Enemy enemy4, Enemy enemy5)
    {
        return enemy4.health > enemy5.health 
            ? enemy4.name + " has more health than " + enemy5.name 
            : enemy5.name + " has more health than " + enemy4.name;
    }

}