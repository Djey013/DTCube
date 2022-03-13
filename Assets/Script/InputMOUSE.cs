using UnityEngine;

public class InputMOUSE : MonoBehaviour
{

    void Update()
    {

        if (Input.GetAxis("Mouse X") > 0)
        {
            Debug.Log("La souris se déplace vers la droite ");
        }

        if (Input.GetAxis("Mouse X") < 0)
        {
            Debug.Log("La souris se déplace vers la gauche ");
        }

        if (Input.GetAxis("Mouse Y") > 0)
        {
            Debug.Log("La souris se déplace vers le haut ");
        }

        if (Input.GetAxis("Mouse Y") < 0)
        {
            Debug.Log("La souris se déplace vers le bas ");
        }


    }

}
