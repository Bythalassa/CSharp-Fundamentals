// ItemInteractuable.cs
// set up of the objects that have this script on them: 
//1. Create it
//2. Add a collider to it (box, sphere, etc) and set it to "Is Trigger"
//3. Add this script to the object

using System;
using Unity.VisualScripting;
using UnityEngine;

public class ItemInteractuable : MonoBehaviour
{
    public int valor = 3;

    void OnTriggerEnter2D(Collider2D isPlayer)
    /*OnTriggerEnter2D y OnTriggerExit2D se llaman por evento no por frame. Son metodos especiales.
     * ocurre cuándo un collider entra o sale del radio asignado. */
    {
        var jugador = isPlayer.GetComponent<PlayerInteraccion>();
        // var = class PlayerInteraccion (formula para asignar a una variable local de otro script)
        // Cuando el jugador entra al trigger del item, el item pregunta:
        //el objeto que entró a MI zona tiene el script PlayerInteraccion? 

        if (jugador != null) // Si el jugador SÍ tiene el script 
            jugador.RegistrarItemCercano(this); //se asigna la entrada de la función RegistrarItemCercano como this
    }

    void OnTriggerExit2D(Collider2D isPlayer)
    {
        var jugador = isPlayer.GetComponent<PlayerInteraccion>();
        if (jugador != null)
            jugador.EliminarItemCercano(this);


    }
}