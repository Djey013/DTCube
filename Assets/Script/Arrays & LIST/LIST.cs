using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LIST : MonoBehaviour
{

    public List<GameObject> mesObjets = new List<GameObject>(); //la LIST

    public GameObject objectToAdd;                              //une variable visible dans l'inspector sous forme de slot

    void Start()
    {
        StartCoroutine(MyCoroutine());                          /* une Coroutine pour faciliter la lecture de la scène et observer l'ajout/suppression de l'élément en temps réel 
                                                                et pas seulement depuis la console  */
        IEnumerator MyCoroutine()
        {
            Debug.Log("Ajout de l'objet dans la liste OK ");    //A RELATIVISER : une simple ligne Debug.Log pour temoigner du fonctionnement de la LIST.
            mesObjets.Add(objectToAdd);                         /* l'action qui va permettre de rajouter un élément dans la LIST mesObjets pendant le lecture de la scene 
                                                                 Cet objet sera celui qui a été glissé/déposer dans la variable objectToAdd    */
            yield return new WaitForSeconds(5);

            Debug.Log("Suppression de l'objet dans la liste OK ");
            mesObjets.Remove(objectToAdd);                      //l'action qui va permettre de supprimer un élément de la LIST pendant le lecture de la scene 
        }

    }

}
