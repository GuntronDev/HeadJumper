using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public Transform Bullet;
    public GameObject ShootPoint;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);        
    }
}
