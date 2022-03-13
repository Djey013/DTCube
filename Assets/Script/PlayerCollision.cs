using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //variables for Audio
    public AudioClip collisionSound;
    private AudioSource persoAudioSource;
    
    
    //variables for movement
    public PlayerMovement movement;

    private void Awake()
    {
        persoAudioSource = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Obstacle")
            {
                Debug.Log("We hit an Obstacle !");
                persoAudioSource.PlayOneShot(collisionSound);
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }

        }

}
