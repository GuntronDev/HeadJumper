using UnityEngine;

public class EnemyAttacks : MonoBehaviour
{
    
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth PlayerHealthSC = collision.collider.GetComponent<PlayerHealth>();
        if (PlayerHealthSC != null)
        {
            PlayerHealthSC.PlayerTakeDamage(80);
            Destroy(gameObject);
        }
    
    
    }

}
