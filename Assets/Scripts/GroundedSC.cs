using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedSC : MonoBehaviour
{
    [SerializeField]public static bool Grounded = true;
    GameObject Player;

    void Start()
    {

    }


    void OnCollisionStay2D(Collision2D collision2D)
    {
        if (collision2D.collider.tag == "Ground")
        {
            Grounded = true;       
        }
    }
     void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.collider.tag == "Ground")
        {
            Grounded = false;
        }
     }
}
