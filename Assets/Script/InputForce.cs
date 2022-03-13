using UnityEngine;

public class InputForce : MonoBehaviour
{
    //create slot to introduce physics for movements & jump. Reference for a rigidbody to add from the inspector.
    public Rigidbody rb;

    //Variables for movements
    public int forwardForce;
    public int sidewaysForce;

    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z)) //forward
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.S)) //backward
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Q)) //left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.D)) //right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        
    }


    
}



