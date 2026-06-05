* PARA : itemCercano, se asume que es un objeto, pero no se ha definido su clase ni su estructura, lo cual es necesario para que el código funcione.
* in rewards to the last line: Create Personalized List.
* Create the List.


public class backtracking : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        LeerInteraccion();

    }

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