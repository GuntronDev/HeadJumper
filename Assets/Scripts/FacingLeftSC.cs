using UnityEngine;

public class FacingLeftSC : MonoBehaviour
{
    private float FacingAxis;
    private bool FacingRight;

    void Update()
    {
        FacingAxis = Input.GetAxisRaw("Horizontal");
        if(FacingAxis < 0 && !FacingRight)
        {
            FacingSide();
        }
        if (FacingAxis > 0 && FacingRight)
        {
            FacingSide();
        }

    }

    void FacingSide()
    {
        transform.Rotate(0, 180, 0);
        FacingRight = !FacingRight;
    }
}
