using UnityEngine;

public class backtracking : MonoBehaviour
{
    void Start()
    {
        string estado = GetEstado(10);

        // puedo usar ese valor N veces:
        Debug.Log(estado);               // Output: vivo
        Debug.Log(estado.ToUpper());      // Output: VIVO
        Debug.Log("la cantidad de letras de la función es: " + estado.Length);   

    }

    void Update()
    { }

    /* 
     * return use 1
    string GetEstado(int vida)
    {
        return vida > 0 ? "vivo" : "muerto";
        Debug.Log(GetEstado(vida)); Unreacheable code detected = this line will 
    never be executed because it is after the return statement.
    }
    

    //Alternativa 1:  guardar el resultado, luego loguearlo
    string GetEstado(int vida)
    {
        string resultado = vida > 0 ? "vivo" : "muerto";
        Debug.Log(resultado);  // ← se ejecuta ANTES de retornar
        return resultado;      // ← ahora sí retorna al final
    }
    */
    //Alternativa 2: Separar el log de la lógica para la RAM. print/Debug.Log se
    //comportan de igual fornma.

    string GetEstado(int vida)
    {
        string resultado = vida > 0 ? "vivo" : "muerto";
        return resultado;      
    }
}
