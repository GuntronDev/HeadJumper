using UnityEngine;

public class FindPlayerSC : MonoBehaviour
{
    [SerializeField] private Transform LookForPlayerStartPointRight;
    [SerializeField] private Transform LookForPlayerStartPointLeft;
    [SerializeField] Rigidbody2D Rigidbody;
    [SerializeField] GameObject Player;
    [SerializeField] private Transform EnemyGroundCheckRight;
    [SerializeField] private Transform EnemyGroundCheckLeft;
    Enemy ClassicEnemy = new Enemy(5f);

    void Start()
    {
        Player = GameObject.Find("Player");
        
    }

    void FixedUpdate()
    {
        FollowPlayerRight();
        FollowPlayerLeft();
    }



    private void Update()
    {

    }
    private void FollowPlayerRight()
    {
        RaycastHit2D GroundRight = Physics2D.Raycast(EnemyGroundCheckRight.position, -EnemyGroundCheckRight.up, 1f);
        Debug.DrawRay(EnemyGroundCheckRight.position, -EnemyGroundCheckRight.up * 1f, Color.blue);

        RaycastHit2D RayRight = Physics2D.Raycast(LookForPlayerStartPointRight.position, LookForPlayerStartPointRight.right, 10f);
        Debug.DrawRay(LookForPlayerStartPointRight.position, LookForPlayerStartPointRight.right * 10f, Color.green);
        if (RayRight)
        {
            

            if (RayRight.collider.tag == "Player" && GroundRight)
            {
                
                
                Debug.DrawRay(LookForPlayerStartPointRight.position, LookForPlayerStartPointRight.right * 10f, Color.red);
                Rigidbody.MovePosition(Rigidbody.position + new Vector2(ClassicEnemy.EnemyMoveSpeed, Rigidbody.velocity.y) * Time.deltaTime);
            }
        }
    }
    private void FollowPlayerLeft()
    {
        RaycastHit2D GroundLeft = Physics2D.Raycast(EnemyGroundCheckLeft.position, -EnemyGroundCheckLeft.up, 1f);
        Debug.DrawRay(EnemyGroundCheckLeft.position, -EnemyGroundCheckLeft.up * 1f, Color.blue);

        RaycastHit2D RayLeft = Physics2D.Raycast(LookForPlayerStartPointLeft.position, -LookForPlayerStartPointLeft.right, 10f);
        Debug.DrawRay(LookForPlayerStartPointLeft.position, -LookForPlayerStartPointLeft.right * 10f, Color.green);
        if (RayLeft)
        {
            if (RayLeft.collider.tag == "Player" && GroundLeft)
            {
                Debug.DrawRay(LookForPlayerStartPointLeft.position, -LookForPlayerStartPointLeft.right * 10f, Color.red);
                Rigidbody.MovePosition(Rigidbody.position + new Vector2(-ClassicEnemy.EnemyMoveSpeed, Rigidbody.velocity.y) * Time.deltaTime);
            }
        }
    }
}

public class Enemy
{

    public Enemy(float enemyMoveSpeed)
    {
        EnemyMoveSpeed = enemyMoveSpeed;

    }
    public float EnemyMoveSpeed
    { get; set; }    
}


