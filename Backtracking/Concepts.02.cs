/*

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;   //← necesario para Keyboard.current

/*TEMP
*Create PlayerMovement
* PARA : itemCercano, se asume que es un objeto, pero no se ha definido su clase ni su estructura, lo cual es necesario para que el código funcione.
* in rewards to the last line: Create Personalized List. 
* Create the List.
* IntentarRecogerItem tiene if que tienen returns que no entiendo. que retorna cada if a la ram?
* Destroy(itemCercano.gameObject); //esto necesita testeo para ver como funciona..
*/

/*Details:
*recommended to create el tyoe para la asignado a la lista antes del objeto MonoBehavior
*recommended to create la lista/array despues de Monobeaviour, antes de start.
*Learning: properties to : Keyboard.current.eKey. ----> para detectar 1 vez por pulsación.
*Ejemplos de aplicación: ideal para abrir inventario, (recoger items)!, o interactuar con NPCs.--
*
*del codigo inicial InputCoreConcept();
2.  como puedo testear esto con objetos en mi escena en unity, además para testearlo creo que seria necesario un return. 
3. puedo usar esta estructura para fomentar presición? o algo relacionado a golpes y ataque de espada? esperando sacar de ello un mejor game feel 

4. Que me dices de las buenas practicas para esto : Mover el objeto en el espacio basado en los valores capturados por el input
5. Ademas de crear direccion con vector3. dir . normalized * radius * speed * time --> Que otros eventos basicos puedo crear para mi plazer y para mi enemy:
 */
/*

public enum Status //etiquetas de asignación para la lista de entidades. 
{
    None,
    Alive,
    Defeat,
}

[Serializable]
public struct Entity 
{
    public string EntityName;
    public Status myStatus;

    public Entity(string entityName, Status status)
    {
        EntityName = entityName;
        this.myStatus = status;
    }
}

public class backtracking : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

        //InputCoreConcept(); 
        //MoverJugador(); 
        LeerInteraccion();

    }

    /* This function needs  a slot in update
    private void InputCoreConcept()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame) //luego de la primera interacción no se vuelve a detectar.
        {
            Debug.Log("E presionado — interactuar");
        }

        if (Keyboard.current.eKey.isPressed) //se actualiza cada frame que la tecla es presionada una vez más.
        {
            Debug.Log("E sostenido este frame");
        }

        if (Keyboard.current.eKey.wasReleasedThisFrame)
        {
            Debug.Log("E soltado");
        }
    }*/
/*

    private bool VerifyInteractuar() //bool necesario para verificar estructura ifs
    {
        if (!Keyboard.current.eKey.wasPressedThisFrame) return false;
        return true;

        if (!Keyboard.current.eKey.isPressed) return false;
        return true;

        if (!Keyboard.current.eKey.wasPressedThisFrame) return false;
        return true;
    }

    private void DebugMeIf()
    {
        if (VerifyInteractuar())  Debug.Log("E presionado → buscar item cercano");
        if (MantenerInteraccion()) Debug.Log("E sostenido → cargando acción...");
        if (SoltarInteraccion())  Debug.Log("E soltado → acción cancelada o completada");
    }
   
    private void LeerInteraccion()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
            IntentarRecogerItem(); //funcion con lógica desarrollada

        if (Keyboard.current.eKey.isPressed)
            MantenerInteraccion(); //funcion que necesita una lógica--

        if (Keyboard.current.eKey.wasReleasedThisFrame)
            SoltarInteraccion();  //funcion que necesita una lógica--
    }

    void IntentarRecogerItem()
    {
        if (itemCercano == null)
        {
            Debug.Log("no hay item cerca");
            return; //que retorna . 
        }

        if (itemCercano.yaRecogido) return; //que retorna 


        string nombre = itemCercano.nombreItem; // help with nombre Item estructura alineada a la lista.
        int valor = itemCercano.valor;// help with nombre Item estructura alineada a la lista.
                                      //que son esos "" .
        string mensaje = nombre != "" ? "recogiste: " + nombre : "item sin nombre";

        Debug.Log(mensaje);
        Destroy(itemCercano.gameObject);
        itemCercano = null;
    }




}
*/