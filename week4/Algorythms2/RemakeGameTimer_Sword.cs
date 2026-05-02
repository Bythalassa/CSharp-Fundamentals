using UnityEngine;

public class RemakeGameTimer_Sword : MonoBehaviour
{
    bool encontrarEspada;
    void Start()
    {
    encontrarEspada;

    }

    void Update()
    {
        //old: if (Input.GetKeyDown(KeyCode.E))
    if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            encontrarEspada = true;
        }
    }

    public bool EsRecogida()
    {
        return encontrarEspada ;
    }
    
}
