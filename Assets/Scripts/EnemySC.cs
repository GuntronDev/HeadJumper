using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySC : MonoBehaviour
{
    public float EnemyHealth = 100;
    public void TakeDamage(int Damage)
    {
        EnemyHealth -= Damage;
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
