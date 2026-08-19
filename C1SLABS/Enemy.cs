using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 10;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage. Remaining health: " + Health);
    }

}
