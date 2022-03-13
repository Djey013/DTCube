using UnityEngine;

public class InputZSQD : MonoBehaviour
{

    public Rigidbody rb; //add rb slot for rigidbody uses (autoforward especially)
    
    //allow input settings in inspector & apply force coefficient to each vectors
    public int forwardForce; 
    public int frontMove; 
    public int backMove;
    public int leftMove;
    public int rightMove;
    public int jumpMove;


    private void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //auto forward
        

        if (Input.GetKey(KeyCode.Z)) //forward
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20 * frontMove);
        }

        if (Input.GetKey(KeyCode.S)) //backward
        {
            transform.Translate(Vector3.back * Time.deltaTime * 20 * backMove);
        }

        if (Input.GetKey(KeyCode.Q)) //left
        {
            transform.Translate(Vector3.left * Time.deltaTime * 20 * leftMove);
        }

        if (Input.GetKey(KeyCode.D)) //right
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20 * rightMove);
        }

        if (Input.GetKey(KeyCode.Space)) //jump
        {
            transform.Translate(Vector3.up * Time.deltaTime * 20 * jumpMove);
        }
    }
}

