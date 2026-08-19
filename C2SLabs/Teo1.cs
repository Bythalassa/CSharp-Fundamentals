using UnityEngine;

public class Teo1 : MonoBehaviour
{
    void Start()
    {
        PokemonA charmander = new PokemonA();
        charmander.PokeName = "charmander";
        charmander.Atk = 6;
        charmander.Vit = 7;
        charmander.Type = PokemonType.Fuego;

        PokemonA squirtle = new PokemonA();
        charmander.PokeName = "squirtle";
        charmander.Atk = 7;
        charmander.Vit = 6;
        charmander.Type = PokemonType.Agua;

        PokemonA Ivysaur = new PokemonA();
        charmander.PokeName = "Ivysaur";
        charmander.Atk = 8;
        charmander.Vit = 8;
        charmander.Type = PokemonType.Planta;

        charmander.Introduction();
        squirtle.Introduction();
        Ivysaur.Introduction();
    }

    void Update()
    {

    }

    public enum PokemonType
    {
        Planta, //->0
        Fuego, //->1
        Agua //->2
    }

    public class PokemonA
    {
        public string PokeName;
        public int Atk;
        public int Vit;
        public PokemonType Type;

        public void Introduction()
        {
            Debug.Log("Soy" + PokeName
                 + "\n Mis puntos de ataque son: " + Atk
                 + "\n Mis puntos de ataque son: " + Vit
                 + "\n Soy de tipo " + Type.ToString());
        }
    } 





}




















