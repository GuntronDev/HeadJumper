using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int playerHealth = 100;


    public void PlayerTakeDamage(int Damage = 70)
    {
        playerHealth -= Damage;
        ShakeCamera.Instance.ShakeCameraFunc(.3f, 5f);
        
    }


}
