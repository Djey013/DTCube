using UnityEngine;

public class Zone : MonoBehaviour
{
   
    //D�clenchement
    void OnTriggerEnter()
        {
            print("Le joueur est entr� dans la zone rouge ! ");
        }

 


    //D�clenchement player only
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            print("Le joueur est entr� dans la zone rouge ! ");
        }

    }


}
