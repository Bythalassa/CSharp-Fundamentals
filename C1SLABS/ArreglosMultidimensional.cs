using UnityEditor.PackageManager;
using UnityEngine;

public class ArreglosMultidimensional : MonoBehaviour
{
    public int[,] notas = new int[3, 4]; //bidimensional 
    public int[,,] notas3 = new int[3, 4, 5]; //tridimensional 

    public string[,] TiposdePokemon = new string [5,5];
    public string[,] TiposYugioh = new string [2,2];

    public string[][] MultiIrregular = new string[3][]; 

    void Start()
    {
        MultiIrregular[0]  = new string[3] {"gia", "Deutsch", "sonic" };
        MultiIrregular[0] = new string[2] { "gia", "Deutsch"};
        MultiIrregular[0] = new string[1] { "gia"};

        //declaración de Arreglo
        notas[0, 0] = 15; // la primera nota del primer estudiante es 15
                          //notas[3, 4] = 10; // cuál es el primer estudiante, sabiendo que todos los arrays empiezan en 0. 
                          //error index out of range.
                          //llamar a variables dentro del Arreglo int tiene como limite [2, 3]
                          //sabiendo que para llamar a cada indice hay que llamar desde el indice 0

        notas[0, 0] = 10;
        notas[0, 1] = 10;
        notas[0, 2] = 10;
        notas[0, 3] = 10;

        notas[1, 0] = 10;
        notas[1, 1] = 10;
        notas[1, 2] = 10;
        notas[1, 3] = 10;

        notas[2, 0] = 10;
        notas[2, 1] = 10;
        notas[2, 2] = 10;
        notas[2, 3] = 10;

        notas[3, 0] = 10;
        notas[3, 1] = 10;
        notas[3, 2] = 10;
        notas[3, 3] = 10;

        MostrarTabla(notas);

        TiposdePokemon[0, 0] = "Normal";
        TiposdePokemon[0, 1] = "Normal";
        TiposdePokemon[0, 2] = "Normal";
        TiposdePokemon[0, 3] = "Normal";
        TiposdePokemon[0, 4] = "Normal";

        TiposdePokemon[1, 0] = "x2";
        TiposdePokemon[1, 1] = "Normal";
        TiposdePokemon[1, 2] = "x0.5";
        TiposdePokemon[1, 3] = "x0.5";
        TiposdePokemon[1, 4] = "Normal";

        TiposdePokemon[2, 0] = "Normal";
        TiposdePokemon[2, 1] = "x2";
        TiposdePokemon[2, 2] = "Normal";
        TiposdePokemon[2, 3] = "Normal";
        TiposdePokemon[2, 4] = "Normal";

        TiposdePokemon[3, 0] = "Normal";
        TiposdePokemon[3, 1] = "Normal";
        TiposdePokemon[3, 2] = "Normal";
        TiposdePokemon[3, 3] = "x0.5";
        TiposdePokemon[3, 4] = "x0.5";

        TiposdePokemon[4, 0] = "Normal";
        TiposdePokemon[4, 1] = "Normal";
        TiposdePokemon[4, 2] = "-0.1";
        TiposdePokemon[4, 3] = "x2";
        TiposdePokemon[4, 4] = "Normal";

        TiposdePokemon[5, 0] = "me aburri";
        TiposdePokemon[5, 1] = "como ";
        TiposdePokemon[5, 2] = "hago";
        TiposdePokemon[5, 3] = "el snake";
        TiposdePokemon[5, 4] = "con esto";

    }
    void Update()
    {
         
    }


    public void MostrarTabla(int[,] misNotas)
    {
        // x = 0 = filas 
        // y = 1 = columnas 
        // -> GetLength (0) => Filas => X
        // -> GetLength (1) => Columnas => Y

        string texto = "Tabla de Notas \n";
        texto += " =========== \n";

        for (int fila = 0; fila < misNotas.GetLength(0); fila++)
        {
            texto += "Estudiante en la fila : " + fila + " : ";
            for (int col = 0; col < misNotas.GetLength(0); col++)
            {
                texto += misNotas[fila, col] + " ";
            }
            texto += "\n";
        }
        Debug.Log(texto);
    }

    public void MostrarTablaDentada(string[][] jaggedArray)
    {
        for (int fila = 0; fila < jaggedArray.Length; fila++)
        {

        }
            

    }


}
