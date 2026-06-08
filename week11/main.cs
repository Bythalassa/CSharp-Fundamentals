using UnityEngine;

public class week11 : MonoBehaviour
{
    //diseño y desarrollo de simuladores y videojuegos <<< entrada >>>
    //diseñovideojuegos <<< salida >>>

    void Start()
    {
        //cadenas de texto 
        //funciones c# para hacer cosas con los strings
        //substring function

        //validar un comando remplazando una palabra

        string mensaje = "Hola jugador";
        mensaje = mensaje.Replace("jugador", "juan");
        Debug.Log(mensaje);//Hola juan

        //validar un comando ignorando una palabra
        string item = "Espada Legendaria";
        bool tieneEspada = item.Contains("Espada");//-> true

        string PlayerName = "Murcielago de las montañas roscosas";
        string sub1 = PlayerName.Substring(0, 10);
        string sub2 = PlayerName.Substring(24 );
        Debug.Log(sub1 + sub2);

        string name2 = "Xx V eX g  Xe tX t X   a X X7X 7xX";
        //->AAAA BB CC
        name2 = name2.ToUpper();
        name2 = name2.Replace("X", " ");
        name2 = name2.Replace(" ", "");

        /*string palabra = "UNITY";
        for (int i = palabra.Length - 1; i ) ;*/

    }

    void Update()
    {
        
    }
}
