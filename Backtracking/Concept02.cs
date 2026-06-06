// ItemInteractuable.cs
//set up of the objects that have this script on them: 
//1. Create it
//2. Add a collider to it (box, sphere, etc) and set it to "Is Trigger"
//3. Add this script to the object


using Unity.VisualScripting;
using UnityEngine;

public class ItemInteractuable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    /*OnTriggerEnter2D al igual que el exit son metodos especiales de Unity2D 
    permite : cuando detecte contacto 2D, busca en el objeto 
    una función que se llame exactamente OnTriggerEnter2D
    y ejecútala*/

    {
        var jugador = other.GetComponent<PlayerInteraccion>();
        if (jugador != null)
            jugador.RegistrarItemCercano(this);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        var jugador = other.GetComponent<PlayerInteraccion>();
        if (jugador != null)
            jugador.EliminarItemCercano(this);
    }
}