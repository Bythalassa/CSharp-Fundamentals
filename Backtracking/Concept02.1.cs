/* PlayerInteraccion.cs
// add Rigidbody to player and set it to "Is Kinematic" when you create player movement script.SS
//3. Add this script to the object

Notas del set up:
**UNO : Para que el Player Controller<Movement funcione, >
Edit → Project Settings → Player → Other Settings → Active Input Handling
Seleccionar Both

**DOS-Object set-up : 
- Circle Collider 2D + Is trigger
- //circle es la estetica -- achica el radio en Circle Collider 2D > Radius a 0.1
- //El editor establece que este ob es trigger
- Script Item Interactuable

**TRES-Player set-up : 
- Rigidbody 2D + Kinematic
- Script Player Interaccion
- Script Movement
- Box Collider 2D no trigger
- //box es la estetica --- no tiene sentido q el player sea trigger

**CUATRO el evento, lógica "IntentarRecogerItem" :
0. Crear una variable de tipo ItemInteractuable su nombre es itemCercano. esta variable es por default null = caja vacia. 
1. la función: Leer interaccion es activado por la Tecla e-
2. Si el jugador esta fuera del radio de detección establecido en el circle collider se mantiene en null 
3. Sino debugea recogiste fuego
4. Destruye el objeto y cambia el estado del item cercano a null. asi podra iterar en otro objeto de null a true.

** agregar delay para que el evento sea más suave

**Cinco: Logica RegistrarItemCercano: 




**Seis: EliminarItemCercano:



*/



using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraccion : MonoBehaviour
{
    private ItemInteractuable itemCercano;

    void Update()
    {
        LeerInteraccion();
    }

    private void LeerInteraccion()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
            IntentarRecogerItem();
    }

    private void IntentarRecogerItem()
    {
        if (itemCercano == null)
        {
            Debug.Log("no hay item cerca");
            return;
        }

        Debug.Log("recogiste: objeto de fuego");
        Destroy(itemCercano.gameObject);
        itemCercano = null;
    }

    public void RegistrarItemCercano(ItemInteractuable item)
    {
        itemCercano = item;
    }

    public void EliminarItemCercano(ItemInteractuable item)
    {
        if (itemCercano == item)
            itemCercano = null;
    }
}