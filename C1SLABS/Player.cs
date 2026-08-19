using UnityEngine;

//Player-Main-Characteristics 
public class Player : MonoBehaviour
{
    public string PlayerName;

    public int X;
    public int Y;

    public float Damage;//->10
    public float Multiplier;//->2
    public bool IsCrit;//-> true
    public float Health;

    public float Speed;

    public float MaxTime = 10;
    public float currentTime;

    public bool isAbilityAblive = true;

    void Start()
    {

        MoventPlayer();
        if (!isAbilityAblive)
        {
            TimerToDoSmt();
        }

        Debug.Log(MostrarSmt2(PlayerName, " buenos dias capitan"));
        string var = MostrarSmt2(PlayerName, " buenos dias capitan");
        MostrarSmt2(var, "gato");


        SumaDeValores(X, Y);
        SumaDeValores(10, 5);

        CalculateDamage(Damage, Multiplier, IsCrit);
        CalculateDamage(14, 3, true) ;
    }
    public void MoventPlayer()
    {
        //AXix
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        direction.Normalize();

        transform.position += direction * Speed * Time.deltaTime;

    }

    public string MostrarSmt2(string playerName, string saludo)
    {
        //Debug.Log(playerName + saludo);

        string result = playerName + saludo;

        return result;
    }

    public void SumaDeValores(int a, int b)
    {
        int sum = a + b;
        Debug.Log(sum);
    }

    public float CalculateDamage(float damage, float multiplier, bool isCrit)
    {
        float DamageTotal = 0;
        if (isCrit)
        {
            DamageTotal = damage * multiplier;
        }
        else
        {
            DamageTotal = damage;
        }

        Debug.Log("El daño total es : " + DamageTotal);

        return DamageTotal;
    }

    public void Shoot()
    {
        //Input.mouse
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePos - transform.position);
        direction.z = 0;
        direction.Normalize();


        /*if(Input.GetMouseButtonDown(0))
        {
          GameObject bullet = Instantiate(/*BulletPrefab ,  transform.position,Quaternion.identity);   
          bullet.transform.up = direction;
        }
              */
    }

    public void SimpleAttack()
    {
        if (isAbilityAblive)
        {
            //->hago lo que tenga que hacer
            isAbilityAblive = false;
        }
    }

    public void TimerToDoSmt()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= MaxTime)
        {
            //-> ejecutar algo
            isAbilityAblive = true;

            currentTime = 0;
        }
    }

}