using UnityEngine;

public class BulletSC : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float BulletSpeed;
    public int DamageOutput = 30;

    void Update()
    {
        Rigidbody.velocity = transform.right * BulletSpeed;
        Shooting shootingSC = GetComponent<Shooting>();

    }

    private void OnTriggerEnter2D(Collider2D BHitInfo)
    {
        Destroy(gameObject);
        EnemySC enemySC = BHitInfo.GetComponent<EnemySC>();
        if (enemySC != null)
        {
            enemySC.TakeDamage(DamageOutput);
        }
    }

}
