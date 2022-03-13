using UnityEngine;

public class Zone : MonoBehaviour
{
   
    //Déclenchement
    void OnTriggerEnter()
        {
            print("Le joueur est entré dans la zone rouge ! ");
        }

 


    //Déclenchement player only
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            print("Le joueur est entré dans la zone rouge ! ");
        }

    }


}
