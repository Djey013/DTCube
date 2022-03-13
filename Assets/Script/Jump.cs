using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public CapsuleCollider col;
    public LayerMask groundLayer;
    public int jumpForce;


    void FixedUpdate()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) //jump
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }


    bool IsGrounded()
    {

        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayer);

    }

}
