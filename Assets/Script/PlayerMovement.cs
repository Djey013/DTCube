using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //create slot to introduce physics for movements & jump.
    public Rigidbody rb;
    
    //Variables for movements
    public int forwardForce;
    public int sidewaysForce;

    //variables for jump
    public CapsuleCollider col;
    public LayerMask groundLayers;
    public int jumpForce;

    //variables for Audio
    public AudioClip jumpSound; 
    private AudioSource persoAudioSource;

    private void Awake()
    {
        persoAudioSource = GetComponent<AudioSource>();
    }
    
    

    // Les mouvements du player
    void Update()
    {
            if (Input.GetKey(KeyCode.Z)) //forward
            {
                rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.S)) //backward
            {
                rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            }
        
            if (Input.GetKey(KeyCode.Q)) //left
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.D)) //right
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) //jump
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
                persoAudioSource.PlayOneShot(jumpSound);
            }

            if (rb.position.y < -10) //GameOver condition if player fall under -10 to Y original position
            {
                FindObjectOfType<GameManager>().EndGame();
            }

    }

            bool IsGrounded()
            {
                return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, 
                 col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);            
            }

    
}



