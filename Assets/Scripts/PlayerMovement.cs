using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    [SerializeField] static float MovementSpeed = 10f;
    [SerializeField]private float JumpForce = 10f;
    private float OurPosition;

    private void Start()
    {
    }
    void Update()
    {
        MoveCharacter();
        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (Input.GetKeyDown("space") && GroundedSC.Grounded == true)
        {
            Rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    public void MoveCharacter()
    {
        OurPosition = Input.GetAxisRaw("Horizontal");
        Rigidbody.velocity = new Vector3(OurPosition * MovementSpeed, Rigidbody.velocity.y, 0);
    }
  
}
